using Application.DTOs.Equipment;
using Domain.Concrets;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.EquipmentException
{
    public class EquipmentCreateException:Exception
    {
        public EquipmentCreateException() : base("The Provided Info is not Valid!")
        {
        }

        public EquipmentCreateException(string? message) : base(message)
        {
        }

        public EquipmentCreateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        //public static void ValidateEquipmentProperties(EquipmentCreateDto equipment)
        //{
        //    if (equipment.Image == null)
        //    {
        //        throw new EquipmentCreateException("Equipment image is missing!");
        //    }

        //    if (string.IsNullOrWhiteSpace(equipment.Name))
        //    {
        //        throw new EquipmentCreateException("Equipment name is required.");
        //    }

        //    if (string.IsNullOrWhiteSpace(equipment.Description))
        //    {
        //        throw new EquipmentCreateException("Equipment Description is required.");
        //    }

        //    if (string.IsNullOrWhiteSpace(equipment.Model))
        //    {
        //        throw new EquipmentCreateException("Equipment Model is required.");
        //    }

        //    if (equipment.ProductionYear == null)
        //    {
        //        throw new EquipmentCreateException("Equipment ProductionYear is required.");
        //    }

        //    if (string.IsNullOrWhiteSpace(equipment.MadeBy))
        //    {
        //        throw new EquipmentCreateException("Equipment MadeBy is required.");
        //    }

        //    if (string.IsNullOrWhiteSpace(equipment.EquipmentType))
        //    {
        //        throw new EquipmentCreateException("Equipment Type is required.");
        //    }


        //    if (equipment.DepartmentId==null)
        //    {
        //        throw new EquipmentCreateException("Equipment Department is required.");
        //    }


        //    if (equipment.CurrentValue == null)
        //    {
        //        throw new EquipmentCreateException("Equipment CurrentValue is required.");
        //    }

        //    if (equipment.Image == null)
        //    {
        //        throw new EquipmentCreateException("Equipment Image is required.");
        //    }

        //}
    }
}
