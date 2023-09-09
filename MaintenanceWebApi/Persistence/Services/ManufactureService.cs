using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.DTOs.Parts;
using Application.DTOs.Service;
using Application.DTOs.UsageHistory;
using Application.Repositories.ManufactureRepo;
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
    public class ManufactureService : IManufactureService
    {
        private readonly IManufactureReadRepository _readRepository;
        private readonly IManufactureWriteRepository _writeRepository;
        private readonly IMapper _mapper;

        public ManufactureService(IManufactureReadRepository readRepository, IManufactureWriteRepository writeRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<List<ManufactureDto>>> GetManufactureForInput(string? name)
        {

            if (string.IsNullOrEmpty(name))
            {
                var manufactures = _readRepository.GetAll().Take(5);
                if (manufactures == null)
                {
                    return new ServiceResult<List<ManufactureDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = manufactures.ToList();
                var manufacturesDto = _mapper.Map<List<ManufactureDto>>(itemss);
                return new ServiceResult<List<ManufactureDto>> { IsSuccess = true, Data = manufacturesDto };
            }
            else
            {
                var manufacturess = _readRepository.GetAll().Where(m => m.Name.ToLower().Contains(name));
                if (manufacturess == null)
                {
                    return new ServiceResult<List<ManufactureDto>> { IsSuccess = true, Data = new List<ManufactureDto>() };
                }
                var itemsss = manufacturess.ToList();
                var modelsDtoo = _mapper.Map<List<ManufactureDto>>(itemsss);
                return new ServiceResult<List<ManufactureDto>> { IsSuccess = true, Data = modelsDtoo };
            }
        }

        public async Task<IServiceResult<Pagination<ManufactureDto>>> GetManufacturesAsync(int? page, int? pageSize)
        {
            if (page == null || pageSize == null)
            {

                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt/2;

                var partss = _readRepository.GetAll();

                if (partss == null)
                {
                    return new ServiceResult<Pagination<ManufactureDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = partss.ToList();
                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var partsDto = _mapper.Map<List<ManufactureDto>>(itemss);

                var paginationn = new Pagination<ManufactureDto>(partsDto, pageValuee, pageCountt, totalCountt);

                return new ServiceResult<Pagination<ManufactureDto>> { IsSuccess = true, Data = paginationn };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<ManufactureDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }

            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;
            var parts = _readRepository.GetAll(tracking: false);
            var count = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
            //var totalCount = parts.Count(e => e.IsDeleted == false && e.IsActive == true);
            var totalCount = count;

            // Calculate the pageCount based on the filtered parts.
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            // Adjust the skip and take operations accordingly.
            var items = parts
                .Where(e => e.IsDeleted == false && e.IsActive == true)
                .Skip(skipCount)
                .Take(takeValue)
                .ToList();

            if (items == null)
            {
                return new ServiceResult<Pagination<ManufactureDto>> { IsSuccess = false, ErrorMessage = "There are no parts in DB" };
            }

            var partsDtoo = _mapper.Map<List<ManufactureDto>>(items);
            var pagination = new Pagination<ManufactureDto>(partsDtoo, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<ManufactureDto>> { IsSuccess = true, Data = pagination };

        }
    }
}
