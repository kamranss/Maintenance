using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.EquipmentType;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.Repositories.EquipmentTypeRepo;
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
    public class EquipmentTypeService : IEquipmentTypeService
    {
        private readonly IEquipmentTypeReadRepository _readRepository;
        private readonly IEquipmentTypeWriteRepository _writeRepository;
        private readonly IMapper _mapper;

        public EquipmentTypeService(IEquipmentTypeReadRepository readRepository, IEquipmentTypeWriteRepository writeRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<Pagination<EquipmentTypeDto>>> GetEquipmentTypesAsync(int? page, int? pageSize)
        {
            if (page == null && pageSize == null)
            {
         
                var manufactureList = _readRepository.GetAll();

                if (manufactureList == null)
                {
                    return new ServiceResult<Pagination<EquipmentTypeDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var items = manufactureList.ToList();

                var totalCount = items.Count;
                //var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
                var manufactureDto = _mapper.Map<List<EquipmentTypeDto>>(items);

                var pagination = new Pagination<EquipmentTypeDto>(manufactureDto, 0, 0, totalCount);

                return new ServiceResult<Pagination<EquipmentTypeDto>> { IsSuccess = true, Data = pagination };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<EquipmentTypeDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }


            return new ServiceResult<Pagination<EquipmentTypeDto>> { IsSuccess = false, ErrorMessage = "SomeThing Went wrong" };
        }

        public async Task<IServiceResult<List<EquipmentTypeDto>>> GetTypesForInput(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                var types = _readRepository.GetAll().Take(5);
                if (types == null)
                {
                    return new ServiceResult<List<EquipmentTypeDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = types.ToList();
                var typesDto = _mapper.Map<List<EquipmentTypeDto>>(itemss);
                return new ServiceResult<List<EquipmentTypeDto>> { IsSuccess = true, Data = typesDto };
            }
            else
            {
                var typess = _readRepository.GetAll().Where(m => m.Name.ToLower().Contains(name));
                if (typess == null)
                {
                    return new ServiceResult<List<EquipmentTypeDto>> { IsSuccess = true, Data = new List<EquipmentTypeDto>() };
                }
                var itemsss = typess.ToList();
                var typesDtos = _mapper.Map<List<EquipmentTypeDto>>(itemsss);
                return new ServiceResult<List<EquipmentTypeDto>> { IsSuccess = true, Data = typesDtos };
            }
        }
    }
}
