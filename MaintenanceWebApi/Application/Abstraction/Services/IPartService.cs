using Application.Abstraction.Contracts;
using Application.DTOs.Manufacture;
using Application.DTOs.Parts;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IPartService
    {
        Task<IServiceResult<Pagination<PartDto>>> GetPartsAsync(int? page, int? pageSize);
    }
}
