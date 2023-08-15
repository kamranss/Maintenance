using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.Repositories.ModelRepo;
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
    public class ModelService : IModelService
    {
        private readonly IModelReadRepository _readRepository;
        private readonly IModelWriteRepository _writeRepository;
        private readonly IMapper _mapper;

        public ModelService(IModelReadRepository readRepository, IModelWriteRepository writeRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<Pagination<ModelDto>>> GetModelsAsync(int? page, int? pageSize)
        {
            if (page == null && pageSize == null)
            {
                //int pageValue = page.Value;
                //int takeValue = pageSize.Value;
                //int skipCount = (pageValue - 1) * takeValue;


                var manufactureList = _readRepository.GetAll();

                if (manufactureList == null)
                {
                    return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var items = manufactureList.ToList();

                var totalCount = items.Count;
                //var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
                var manufactureDto = _mapper.Map<List<ModelDto>>(items);

                var pagination = new Pagination<ModelDto>(manufactureDto, 0, 0, totalCount);

                return new ServiceResult<Pagination<ModelDto>> { IsSuccess = true, Data = pagination };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }


            return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "SomeThing Went wrong" };
        }
    }
}
