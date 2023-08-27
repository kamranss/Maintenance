using Application.Abstraction.Contracts;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.Model;
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
        Task<IServiceResult<Pagination<DepartmentListDto>>> GetDepartmentsAsync(int? page, int? pageSize);
        //List<DepartmentGetDto> GetDepartments();
        Task<IServiceResult<DepartmentCreateDto>> CreateDepartmentAsync(DepartmentCreateDto department);
        //void CreateDepartment(DepartmentCreateDto product);

        Task<IServiceResult<DepartmentUpdateDto>> UpdateDepartmentAsync(DepartmentUpdateDto department);
        void DeleteDepartment(int? id);
        Task<IServiceResult<DepartmentDto>> DeleteDepartmentAsync(int id);
        DepartmentGetDto FindDepartment(int? id);
        Task<IServiceResult<DepartmentListDto>> FindDepartmentAsync(int? id);
        //Equipment MapDtoToEntity(EquipmentUpdateDto product);
        EquipmentGetDto Deatil(int? id);
        EquipmentGetDto IsDepartmentExist(int? id);

        Task<IServiceResult<List<DepartmentDto>>> GetDepartmentsForInput(string name);
        //void SaveChanges();

    }
}
