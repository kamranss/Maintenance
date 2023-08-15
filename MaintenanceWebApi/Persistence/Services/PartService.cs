using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.OperationSite;
using Application.DTOs.Parts;
using Application.Repositories.EquipmentPartRepo;
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
    public class PartService : IPartService
    {
        private readonly IPartReadRepository _readRepository;
        private readonly IMapper _mapper;

        public PartService(IPartReadRepository readRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<Pagination<PartDto>>> GetPartsAsync(int? page, int? pageSize)
        {
            if (page == null && pageSize == null)
            {
                //int pageValue = page.Value;
                //int takeValue = pageSize.Value;
                //int skipCount = (pageValue - 1) * takeValue;


                var parts = _readRepository.GetAll();

                if (parts == null)
                {
                    return new ServiceResult<Pagination<PartDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var items = parts.ToList();

                var totalCount = items.Count;
                //var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
                var partsDto = _mapper.Map<List<PartDto>>(items);

                var pagination = new Pagination<PartDto>(partsDto, 0, 0, totalCount);

                return new ServiceResult<Pagination<PartDto>> { IsSuccess = true, Data = pagination };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<PartDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }


            return new ServiceResult<Pagination<PartDto>> { IsSuccess = false, ErrorMessage = "SomeThing Went wrong" };
        }
    }
}
