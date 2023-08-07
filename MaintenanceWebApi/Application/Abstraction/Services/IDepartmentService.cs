using Application.Abstraction.Contracts;
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
 
        //Pagination<DepartmentGetDto> GetDepartmentsPortion(int page, int take);
        Task<IServiceResult<Pagination<DepartmentListDto>>> GetDepartmentsAsync(int page, int take);
        List<DepartmentGetDto> GetDepartments();
        void CreateDepartment(DepartmentCreateDto product);
        void DeleteDepartment(int? id);
        DepartmentGetDto FindDepartment(int? id);
        //Equipment MapDtoToEntity(EquipmentUpdateDto product);
        EquipmentGetDto Deatil(int? id);
        void SaveDepartmentImage(IFormFile newImage, Equipment equipment);
        EquipmentGetDto IsDepartmentExist(int? id);
        void SaveChanges();

    }
}
