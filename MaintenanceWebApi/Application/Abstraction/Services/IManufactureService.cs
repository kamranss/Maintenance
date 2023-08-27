using Application.Abstraction.Contracts;
using Application.DTOs.Equipment;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IManufactureService
    {
        Task<IServiceResult<Pagination<ManufactureDto>>> GetManufacturesAsync(int? page, int? pageSize);
        Task<IServiceResult<List<ManufactureDto>>> GetManufactureForInput(string name);
    }
}
