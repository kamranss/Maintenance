using Application.DTOs.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.User
{
    public class UserLoginDtoValidator:AbstractValidator<UserLoginDto>
    {
        public UserLoginDtoValidator()
        {

            //RuleFor(u => u.UserNameOrEmail).NotEmpty().WithMessage("Please enter a username.");
            //RuleFor(u => u.Password).NotEmpty().WithMessage("Please enter a password.");
        }
    }
}
