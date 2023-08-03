using Application.DTOs.Equipment;
using Domain.Concrets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.Equipment
{
    public class EquipmentDtoValidation: AbstractValidator<EquipmentDto>
    {
        public EquipmentDtoValidation()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Not leave empty")
                .MaximumLength(20).WithMessage("Max lenght should be 20");

            RuleFor(e => e.Description)
                .NotEmpty().WithMessage("Can not be null")
                .MaximumLength(20).WithMessage("Max lenght should be 20");

        }


        //private bool ValidEquipmentStatus(EquipmentStatus status)
        //{
        //    return Enum.IsDefined(typeof(EquipmentStatus), status);
        //}
    }
}
