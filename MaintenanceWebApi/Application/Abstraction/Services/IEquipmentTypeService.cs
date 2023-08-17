using Application.Abstraction.Contracts;
using Application.DTOs.EquipmentType;
using Application.DTOs.Manufacture;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IEquipmentTypeService
    {
        Task<IServiceResult<Pagination<EquipmentTypeDto>>> GetEquipmentTypesAsync(int? page, int? pageSize);
    }
}
