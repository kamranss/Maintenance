using Application.DTOs.Department;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.Department
{
    public class DepartmentCreateValidator:AbstractValidator<DepartmentCreateDto>
    {
        public DepartmentCreateValidator()
        {
            RuleFor(p => p.Name)
              .NotEmpty().WithMessage("Not leave empty")
              .MaximumLength(20).WithMessage("Max lenght should be 20")
              .MinimumLength(5).WithMessage("Max Lenght should be 5");
            
            RuleFor(p => p.Name)
              .MaximumLength(20).WithMessage("Max lenght should be 50");
        }
    }
}
