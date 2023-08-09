using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.MpRepo;
using Application.RequestParameters;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class MPService : IMPService
    {

        private readonly IMpReadRepository _readRepository;
        private readonly IMpWriteRepository _writeRepository;
        private readonly IMapper _mapper;
        private IMemoryCache _memoryCach;

        public MPService(IMpReadRepository readRepository, IMpWriteRepository writeRepository, IMapper mapper, IMemoryCache memoryCach)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
        }

        public Task<IServiceResult<MaintenancePlanCreateDto>> CreateMPAsync(MaintenancePlanCreateDto service)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<MaintenancePlanDto>> DeleteMPAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<MaintenancePlanDto>> FindMPAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IServiceResult<Pagination<MaintenancePlanDto>>> GetMPsAsync(int? page, int? pagesize)
        {
            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0))
            {
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;

           
            var MpsFromDb = _readRepository.GetAll(tracking: false);

            var items = MpsFromDb
             .Skip((pageValue - 1) * takeValue)
             .Take(takeValue)
             .Where(e => e.IsDeleted == false)
             .ToList();


            if (items == null)
            {
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "There is no MP in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var MpListDto = _mapper.Map<List<MaintenancePlanDto>>(items);
            var pagination = new Pagination<MaintenancePlanDto>(MpListDto, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = true, Data = pagination };

        } // done

        public Task<IServiceResult<MaintenancePlanCreateDto>> UpdateMPAsync(MaintenancePlanUpdateDto department)
        {
            throw new NotImplementedException();
        }
    }
}
