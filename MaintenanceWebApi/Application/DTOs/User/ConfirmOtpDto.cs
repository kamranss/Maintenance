using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.User
{
    public class ConfirmOtpDto
    {
        public string Email { get; set; }
        [Required]
        public string OTP { get; set; }


        public ConfirmOtpDto()
        {

        }
        public ConfirmOtpDto(string email, string otp)
        {
            Email = email;
            OTP = otp;
        }
    }
}
