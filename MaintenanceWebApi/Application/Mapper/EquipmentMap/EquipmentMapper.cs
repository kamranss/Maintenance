using Application.DTOs.Equipment;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper.EquipmentMap
{
    public class EquipmentMapper:IEquipmentMapper
    {
        public Equipment FindCategoryFromList(int? id, List<Equipment> categories)
        {
            throw new NotImplementedException();
        }

        public Equipment MapEquipment(EquipmentCreateDto equipmentCreateDto)
        {
            throw new NotImplementedException();
        }

        public void MapUpdateCacheEquipment(EquipmentUpdateDto equipmentUpdateDto, EquipmentUpdateDto existEquipmentInCache)
        {
            throw new NotImplementedException();
        }

        public void MapUpdateEquipemnt(Equipment equipment, EquipmentUpdateDto equipmentUpdateDto) // done partially but category have more fields
        {
            equipment.Name = equipmentUpdateDto.Name;
            equipment.Description = equipmentUpdateDto.Description;
        }
    }
}
