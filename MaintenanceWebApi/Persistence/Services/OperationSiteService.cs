using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.DTOs.OperationSite;
using Application.Repositories.OperationSiteRepo;
using Application.RequestParameters;
using AutoMapper;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class OperationSiteService : IOperationSiteService
    {
        private readonly IReadOperationSiteRepository _readRepository;
        private readonly IMapper _mapper;

        public OperationSiteService(IReadOperationSiteRepository readRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<Pagination<OperationSiteDto>>> GetOperationSitesAsync(int? page, int? pageSize)
        {
            if (page == null && pageSize == null)
            {
                //int pageValue = page.Value;
                //int takeValue = pageSize.Value;
                //int skipCount = (pageValue - 1) * takeValue;


                var operationSite = _readRepository.GetAll();

                if (operationSite == null)
                {
                    return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var items = operationSite.ToList();

                var totalCount = items.Count;
                //var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
                var manufactureDto = _mapper.Map<List<OperationSiteDto>>(items);

                var pagination = new Pagination<OperationSiteDto>(manufactureDto, 0, 0, totalCount);

                return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = true, Data = pagination };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }


            return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "SomeThing Went wrong" };
        }
    }
}
