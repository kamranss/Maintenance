using Application.Abstraction.Services.Authentications;
using Application.DTOs.User;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Ocsp;
using Persistence.Migrations;
using Persistence.Services.Account;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Net.WebRequestMethods;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService; // this service created by me within service layer for email vertification
        private readonly IFileService _fileService;
        private readonly IConfiguration _config;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IConfiguration config, IEmailService emailService, IFileService fileService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _emailService = emailService;
            _fileService = fileService;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] UserRegisterDto userRegisterDto)
        {
            AppUser existUser = await _userManager.FindByNameAsync(userRegisterDto.UserName);
            if (existUser != null) return BadRequest(new { errors = new[] { $"Username '{userRegisterDto.UserName}' is already taken." } });

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(new { errors });
            }
            //string otp = OtpService.GenerateOTP();


            Random random = new Random();
            string otpnumber = random.Next(100000, 999999).ToString();
            AppUser user = new AppUser();
            user.Email = userRegisterDto.Email;
            user.Name = userRegisterDto.Name;
            user.Surname = userRegisterDto.Surname;
            user.UserName = userRegisterDto.UserName;
            string FullName = userRegisterDto.Name + " " + userRegisterDto.Surname;
            user.ConnectionId = null;
            user.OTP = otpnumber;
            user.IsActive = true;
            var result = await _userManager.CreateAsync(user, userRegisterDto.Password);

            if (!result.Succeeded)
            {
                var errors = ModelState.Values
                   .SelectMany(v => v.Errors)
                   .Select(e => e.ErrorMessage)
                   .ToList();
                return BadRequest(new { errors });
            }
            //var ExistUserAfterCreation = await _userManager.FindByNameAsync(userRegisterDto.UserName);

            //if (!await _roleManager.RoleExistsAsync(Roles.MEMBER.ToString()))
            //{
            //    // Create the role if it doesn't exist
            //    var newRole = new IdentityRole(Roles.MEMBER.ToString());
            //    var createRoleResult = await _roleManager.CreateAsync(newRole);
            //    if (!createRoleResult.Succeeded)
            //    {
            //        // Handle role creation failure
            //        return BadRequest("Failed to create role.");
            //    }
            //}

            //result = await _userManager.AddToRoleAsync(ExistUserAfterCreation, Roles.MEMBER.ToString());
            if (!result.Succeeded)
            {
                var errors = ModelState.Values
                   .SelectMany(v => v.Errors)
                   .Select(e => e.ErrorMessage)
                   .ToList();
                return BadRequest(new { errors });
            }

            string body = string.Empty;
            string path = "wwwroot/templates/verify.html";
            string subject = "hey you verify your email!";

            body = _fileService.ReadFile(path, body);
            body = body.Replace("{{otp}}", otpnumber);
            body = body.Replace("{{fullname}}", FullName);

            _emailService.Send(user.Email, subject, body);
            return StatusCode(201);

        }


       

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] UserLoginDto loginDto)
        {
            AppUser user = await _userManager.FindByNameAsync(loginDto.UserNameOrEmail) ?? await _userManager.FindByEmailAsync(loginDto.UserNameOrEmail);

            if (user == null)
            {
                var errors = ModelState.Values
                       .SelectMany(v => v.Errors)
                       .Select(e => e.ErrorMessage)
                       .ToList();
                return BadRequest(new { errors });
            }

            if (!user.IsActive)
            {
                var errors = ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage)
                     .ToList();
                return BadRequest(new { errors });
            }
        
            var passwordResult = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!passwordResult)
            {
                var errors = ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage)
                     .ToList();
                return BadRequest(new { errors });
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, loginDto.RememberMe, true);
            // generate token 

            if (result.IsLockedOut) 
            {
                var errors = ModelState.Values
                      .SelectMany(v => v.Errors)
                      .Select(e => e.ErrorMessage)
                      .ToList();
                return BadRequest(new { errors });
            }
            if (!result.Succeeded)
            {
                var errors = ModelState.Values
                      .SelectMany(v => v.Errors)
                      .Select(e => e.ErrorMessage)
                      .ToList();
                return BadRequest(new { errors });
            }
     
            var userRoles = await _userManager.GetRolesAsync(user);
            var tokenHandler = new JwtSecurityTokenHandler();
             // convering string key to bytes
            var claimList = new List<Claim>(); // claim data will be stored within the claim
            claimList.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));  // instead of ClaimTypes.NameIdentifier we could just write id
            claimList.Add(new Claim("username", user.UserName));
            claimList.Add(new Claim("email", user.Email));
            if (userRoles.Count!=0)
            {
                claimList.Add(new Claim("role", userRoles[0] ?? Roles.MEMBER.ToString()));
            }

            claimList.Add(new Claim("role", "MEMBER"));

            foreach (var role in userRoles)
            {
                claimList.Add(new Claim("role", role));
            }
            var tokenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var key = _config["JWT:Key"];
            Console.WriteLine(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(claimList),
                Expires =  loginDto.RememberMe ? DateTime.UtcNow.AddDays(30) : DateTime.UtcNow.AddMinutes(20),
                Issuer = _config["JWT: Issuer"],
                Audience = _config["JWT: Audience"],
                SigningCredentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256.ToString())
            };
            try
            {
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return Ok(new { token = tokenHandler.WriteToken(token), message = "succesfull" });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Token creation error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }


        [Route("rolegenerator")]
        [HttpGet]
        public async Task<IActionResult> AddRole()
        {

            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
            }
            return StatusCode(201);
        }

        [Route("ConfirmEmail")]
        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(ConfirmOtpDto confirmAccountDto)
        {
            AppUser existUser = await _userManager.FindByEmailAsync(confirmAccountDto.Email);

            if (existUser.OTP != confirmAccountDto.OTP || string.IsNullOrEmpty(confirmAccountDto.OTP))
            {
                //TempData["Error"] = "Wrong OTP";
                return BadRequest("Invalid OTP");
            }

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(existUser);
            await _userManager.ConfirmEmailAsync(existUser, token);

            //await _signInManager.SignInAsync(existUser, false);

            return Ok("Email verify succesfully");
        }

        [Route("ResentOtp")]
        [HttpPost]
        public async Task<IActionResult> ResendOTP(string email) 
        {
            //string otp = OtpService.GenerateOTP();

            Random random = new Random();
            string otpnumber = random.Next(100000, 999999).ToString();
            AppUser existUser = await _userManager.FindByEmailAsync(email);
            existUser.OTP = otpnumber; // we are renewing previous Otp
            var result = await _userManager.UpdateAsync(existUser);
            if (!result.Succeeded)
            {
                var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
                return BadRequest(new { errors });
            }

            string body = string.Empty;
            string path = "wwwroot/templates/verify.html";
            string subject = "hey you verify your email!";

            body = _fileService.ReadFile(path, body);
            body = body.Replace("{{otp}}", otpnumber);
            body = body.Replace("{{fullname}}", existUser.Name+ " " +existUser.Surname);

            _emailService.Send(existUser.Email, subject, body);
            return StatusCode(201);
            

        }
    }

      
    
}
