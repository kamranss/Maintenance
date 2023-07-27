using Application.DTOs.Equipment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.Equipment
{
    public class EquipmenCreatetValidator:AbstractValidator<EquipmentCreateDto>
    {
        public EquipmenCreatetValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Not leave empty")
                .MaximumLength(20).WithMessage("Max lenght should be 20");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Can not be null")
                .MaximumLength(20).WithMessage("Max lenght should be 20");

            //RuleFor(p => p.SalePrice)
            //    .NotNull().WithMessage("Can not be null")
            //    .GreaterThanOrEqualTo(0).WithMessage("Should be greater than 0 or equal");

            //RuleFor(p => p.CostPrice)
            //    .NotNull().WithMessage("Can not  be null")
            //    .GreaterThanOrEqualTo(0).WithMessage("greater then ");

            
            //RuleFor(p => p).Custom((p, context) =>
            //{
            //    if (p.CostPrice > p.SalePrice)
            //    {
            //        context.AddFailure("CostPrice", "CostPrice cannot be greater than SalePrice");
            //    }
            //});
        }
    }
}
