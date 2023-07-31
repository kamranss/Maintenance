using Application.DTOs.Equipment;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class EquipmentMapper
    {
        public void MapUpdateEquipemnt(Equipment equipment, EquipmentUpdateDto equipmentUpdateDto) // done partially but category have more fields
        {
            equipment.Name = equipmentUpdateDto.Name;
            equipment.Description = equipmentUpdateDto.Description;
        }
    }
}
