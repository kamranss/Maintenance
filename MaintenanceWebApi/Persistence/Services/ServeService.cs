using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Service;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class ServeService : IServeServices
    {
        public Task<IServiceResult<ServiceCreateDto>> CreateServiceAsync(ServiceCreateDto service)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<ServiceDto>> DeleteServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<ServiceDto>> FindServiceAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<Pagination<ServiceDto>>> FindServicesByMPidAsync(int? page, int? take, int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<Pagination<ServiceDto>>> GetServicesAsync(int? page, int? take)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<DepartmentUpdateDto>> UpdateServiceAsync(DepartmentUpdateDto department)
        {
            throw new NotImplementedException();
        }
    }
}
