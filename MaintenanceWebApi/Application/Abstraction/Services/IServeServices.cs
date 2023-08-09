using Application.Abstraction.Contracts;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.Service;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IServeServices
    {
        Task<IServiceResult<Pagination<ServiceDto>>> GetServicesAsync(int? page, int? take);
        Task<IServiceResult<Pagination<ServiceDto>>> FindServiceAsync(int? id);
        Task<IServiceResult<ServiceCreateDto>> CreateServiceAsync(ServiceCreateDto service);
        Task<IServiceResult<DepartmentUpdateDto>> UpdateServiceAsync(DepartmentUpdateDto department);
        Task<IServiceResult<ServiceDto>> DeleteServiceAsync(int id);
        //DepartmentGetDto FindDepartment(int? id);
        //Task<IServiceResult<DepartmentListDto>> FindDepartmentAsync(int? id);
        //EquipmentGetDto Deatil(int? id);
        //EquipmentGetDto IsDepartmentExist(int? id);
        //void DeleteDepartment(int? id);
    }
}
