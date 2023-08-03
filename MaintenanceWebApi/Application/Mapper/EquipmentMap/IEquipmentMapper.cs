using Application.DTOs.Equipment;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

namespace Application.Mapper.EquipmentMap
{
    public interface IEquipmentMapper
    {
        void MapUpdateEquipemnt(Equipment equipment, EquipmentUpdateDto equipmentUpdateDto);
        Equipment MapEquipment(EquipmentCreateDto equipmentCreateDto);
        //void AddCategoryToList(List<Equipment> categoriesList, Category category);
        public Equipment FindCategoryFromList(int? id, List<Equipment> categories);
        public void MapUpdateCacheEquipment(EquipmentUpdateDto equipmentUpdateDto, EquipmentUpdateDto existEquipmentInCache);
        //void SaveEquipmentImage(IFormFile newImage, EquipmentCreateDto equipmentCreateDto);

    }
}
