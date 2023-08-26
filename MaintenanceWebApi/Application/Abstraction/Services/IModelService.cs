using Application.Abstraction.Contracts;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.RequestParameters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IModelService
    {
        Task<IServiceResult<Pagination<ModelDto>>> GetModelsAsync(int? page, int? pageSize);

        Task<IServiceResult<List<ModelDto>>> GetModelsForInput(string name);
    }
}
