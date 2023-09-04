using Application.DTOs.Equipment;
using Application.DTOs.UsageHistory;
using Domain.Concrets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.UsageHistory
{
    public class UsageHistoryCreateValidator: AbstractValidator<UsageHistoryCreateDto>
    {

        public UsageHistoryCreateValidator()
        {
            //RuleFor(e => e.OperationName)
            // .IsInEnum().WithMessage("Invalid operation name");

            //RuleFor(e => e.Remark)
            //    .NotEmpty().WithMessage("Remark cannot be empty")
            //    .MaximumLength(20).WithMessage("Max length should be 20");

            //RuleFor(e => e.EquipmentId)
            //    .NotEmpty().WithMessage("EquipmentId cannot be empty");
           

        }
    }
}
