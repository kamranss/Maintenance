using Application.Abstraction.Contracts;
using Application.DTOs.Model;
using Application.DTOs.OperationSite;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IOperationSiteService
    {
        Task<IServiceResult<Pagination<OperationSiteDto>>> GetOperationSitesAsync(int? page, int? pageSize);
        Task<IServiceResult<List<OperationSiteDto>>> GetOperationSitesForInput(string name);
    }
}
