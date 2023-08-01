using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.RequestParameters;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Abstraction.Services
{
    public interface IDepartmentService
    {
 

        Pagination<DepartmentGetDto> GetDepartment(int page, int take);
        List<DepartmentGetDto> GetDepartments();
        void CreateDepartment(DepartmentCreateDto product);
        void DeleteDepartment(int? id);
        DepartmentGetDto FindDepartment(int? id);
        //Equipment MapEquipemntDtoToEntity(EquipmentUpdateDto product);

        ////void RemoveImage(int? id);

        //EquipmentGetDto Deatil(int? id);

        //void SaveEquipmentImage(IFormFile newImage, Equipment equipment);
        //void SaveChanges();
        //EquipmentGetDto IsEquipmentExist(int? id);
        //Image FindImage(int? id);
        //void RemoveEquipmentImage(Image image);
    }
}
