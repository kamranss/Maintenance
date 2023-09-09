using Application.Abstraction.Services.Authentications;
using Application.DTOs.User;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ConfirmEmail(ConfirmAccountVM confirmAccountVM)
        //{
        //    AppUser existUser = await _userManager.FindByEmailAsync(confirmAccountVM.Email);

        //    if (existUser.OTP != confirmAccountVM.OTP || string.IsNullOrEmpty(confirmAccountVM.OTP))
        //    {
        //        TempData["Error"] = "Wrong OTP";
        //        return RedirectToAction(nameof(VertifyEmail), new { Email = confirmAccountVM.Email });
        //    }

        //    string token = await _userManager.GenerateEmailConfirmationTokenAsync(existUser);
        //    await _userManager.ConfirmEmailAsync(existUser, token);

        //    await _signInManager.SignInAsync(existUser, false);

        //    return RedirectToAction(nameof(Login));
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResendOTP(string email) // this method serves for generating new OTP and sending this otp to user email
        //{
        //    string otp = OtpService.GenerateOTP();
        //    AppUser existUser = await _userManager.FindByEmailAsync(email);
        //    existUser.OTP = otp; // we are renewing previous Otp
        //    await _userManager.UpdateAsync(existUser);
        //    string body = string.Empty;
        //    string path = "wwwroot/templates/verify.html";
        //    string subject = "hey you verify your email!";

        //    body = _fileService.ReadFile(path, body);
        //    body = body.Replace("{{otp}}", otp);
        //    body = body.Replace("{{fullname}}", existUser.FullName);

        //    _emailService.Send(existUser.Email, subject, body);

        //    //return RedirectToAction("index", "home", new {area="AdminArea"}); // if we want redirect to another area we should do like that 
        //    //return RedirectToAction("index", "home");

        //    return RedirectToAction(nameof(VertifyEmail), new { Email = existUser.Email }); // we are sending Email within the anonim object to the action 

        //}

        //public async Task<IActionResult> ChangePassowrd(ChangePasswordVM changePasswordVM)
        //{
        //    if (!ModelState.IsValid) return View();
        //    AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name); // finding user referring to session
        //    IdentityResult result = await _userManager.ChangePasswordAsync(existUser, changePasswordVM.CurrentPassword, changePasswordVM.NewPassword);

        //    if (result.Succeeded)
        //    {
        //        ViewBag.IsSuccess = true;
        //        return View(changePasswordVM);
        //    }
        //    else
        //    {

        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);

        //        }
        //        return View(changePasswordVM);
        //    }
        //}

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto loginDto)
        {
            AppUser user = await _userManager.FindByEmailAsync(loginDto.UserNameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByNameAsync(loginDto.UserNameOrEmail);
                if (user == null)
                {
                    return NotFound();
                }
            }
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!result)
            {
                return NotFound();
            }
            // generate token 
            var userRoles = await _userManager.GetRolesAsync(user);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_config["JWT:Key"]);  // convering string key to bytes
            var claimList = new List<Claim>(); // claim data will be stored within the claim
            claimList.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));  // instead of ClaimTypes.NameIdentifier we could just write id
            claimList.Add(new Claim("username", user.UserName));
            claimList.Add(new Claim("email", user.Email));
            claimList.Add(new Claim("role", userRoles[0]));

            foreach (var role in userRoles)
            {
                claimList.Add(new Claim("role", role));
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // all of the description also should be implemented within program class 
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.UtcNow.AddMinutes(10),
                Issuer = _config["JWT: Issuer"],
                Audience = _config["JWT: Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { token = tokenHandler.WriteToken(token), message = "succesfull" });
            //return Ok(result);

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
    }

      
    
}
