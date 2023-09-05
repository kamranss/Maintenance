using Application.DTOs.Equipment;
using Domain.Concrets;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.Equipment
{
    public class EquipmenCreatetValidator : AbstractValidator<EquipmentCreateDto>
    {
        public EquipmenCreatetValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Not leave empty")
                .MaximumLength(20).WithMessage("Max lenght should be 20");

            //RuleFor(e => e.Description)
            //    .NotEmpty().WithMessage("Can not be empty")
            //    .MaximumLength(20).WithMessage("Max lenght should be 20");

            RuleFor(e => e.ProductionYear)
                .NotEmpty().WithMessage("Can not be null");

            //RuleFor(e => e.SeriaNumber)
            //    .NotEmpty().WithMessage("Can not be empty")
            //    .MinimumLength(4).WithMessage("Min lenght should be 4");


            RuleFor(e => e.ManufactureId)
               .NotNull().WithMessage("You should select from the list");

            //RuleFor(e => e.SeriaNumber)
            //    .NotEmpty().WithMessage("Can not be null")
            //    .MaximumLength(4).WithMessage("You should select from the list");

            RuleFor(e => e.Capacity)
                .NotEmpty().WithMessage("Can not be null")
                .MaximumLength(4).WithMessage("You should select from the list");


            //RuleFor(e => e.EquipmentType)
            //    .NotEmpty().WithMessage("Can not be null")
            //    .MaximumLength(4).WithMessage("You should select from the list");

            //RuleFor(e => e.OperationSiteid)
            //     .NotEmpty().WithMessage("Can not be null");

            //RuleFor(e => e.DepartmentId)
            //     .NotEmpty().WithMessage("Can not be null");

            //RuleFor(e => e.UsageLocation)
            //     .NotEmpty().WithMessage("Can not be null")
            //     .MinimumLength(4).WithMessage("You should select from the list");


            //RuleFor(p => p.)
            //     .Must(BeAValidEquipmentStatus).WithMessage("Invalid status value.");
            //RuleFor(p => p.SalePrice)
            //    .NotNull().WithMessage("Can not be null")
            //    .GreaterThanOrEqualTo(0).WithMessage("Should be greater than 0 or equal");


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
