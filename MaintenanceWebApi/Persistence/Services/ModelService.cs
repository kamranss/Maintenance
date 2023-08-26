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
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Persistence.Services
{
    public class ModelService : IModelService
    {
        private readonly IModelReadRepository _readRepository;
        private readonly IModelWriteRepository _writeRepository;
        private readonly IMapper _mapper;
        private readonly System.Timers.Timer _dailyTimer;

        public ModelService(IModelReadRepository readRepository, IModelWriteRepository writeRepository, IMapper mapper )
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;

            //System.Timers.Timer dailyTimer
            //_dailyTimer = new System.Timers.Timer(TimeSpan.FromHours(24).TotalMilliseconds);
            //_dailyTimer.Elapsed += DailyTimerElapsed;
            //_dailyTimer.Start();
        }

        //private async void DailyTimerElapsed(object sender, ElapsedEventArgs e)
        //{
        //    // Run the method when the timer elapses
        //    await GetModelsAsync(null, null);
        //}


        public async Task<IServiceResult<Pagination<ModelDto>>> GetModelsAsync(int? page, int? pageSize)
        {
             if (page == null || pageSize == null)
            {

                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt;

                var partss = _readRepository.GetAll();

                if (partss == null)
                {
                    return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = partss.ToList();
                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var partsDto = _mapper.Map<List<ModelDto>>(itemss);

                var paginationn = new Pagination<ModelDto>(partsDto, pageValuee, pageCountt, totalCountt);

                return new ServiceResult<Pagination<ModelDto>> { IsSuccess = true, Data = paginationn };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }

            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            //int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;
            var parts = _readRepository.GetAll(tracking: false);

            var items = parts
                    .Skip((pageValue - 1) * takeValue)
                    .Take(takeValue)
                    .Where(e => e.IsDeleted == false && e.IsActive == true)
                    .ToList();


            if (items == null)
            {
                return new ServiceResult<Pagination<ModelDto>> { IsSuccess = false, ErrorMessage = "There is no parts in DB" };
            }

        
            var totalCount = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count(); ;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var partsDtoo = _mapper.Map<List<ModelDto>>(items);
            var pagination = new Pagination<ModelDto>(partsDtoo, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<ModelDto>>{ IsSuccess = true, Data = pagination };
        }

        public async Task<IServiceResult<List<ModelDto>>> GetModelsForInput(string? name)
        {
            //if (name == null)
            //{
            //    var models = _readRepository.GetAll().Take(5);
            //    if (models == null)
            //    {
            //        return new ServiceResult<List<ModelDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
            //    }
            //    var itemss = models.ToList();
            //    var modelsDto = _mapper.Map<List<ModelDto>>(itemss);
            //    return new ServiceResult<List<ModelDto>> { IsSuccess = true, Data = modelsDto };
            //}


            //var modelss = _readRepository.GetAll().Where(m => m.Name.Contains(name));
            //if (modelss == null)
            //{

            //}
            //var itemsss = modelss.ToList();
            //var modelsDtoo = _mapper.Map<List<ModelDto>>(itemsss);
            //return new ServiceResult<List<ModelDto>> { IsSuccess = true, Data = modelsDtoo };

            if (string.IsNullOrEmpty(name))
            {
                var models = _readRepository.GetAll().Take(5);
                if (models == null)
                {
                    return new ServiceResult<List<ModelDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = models.ToList();
                var modelsDto = _mapper.Map<List<ModelDto>>(itemss);
                return new ServiceResult<List<ModelDto>> { IsSuccess = true, Data = modelsDto };
            }
            else
            {
                var modelss = _readRepository.GetAll().Where(m => m.Name.ToLower().Contains(name));
                if (modelss == null)
                {
                    return new ServiceResult<List<ModelDto>> { IsSuccess = true, Data = new List<ModelDto>() };
                }
                var itemsss = modelss.ToList();
                var modelsDtoo = _mapper.Map<List<ModelDto>>(itemsss);
                return new ServiceResult<List<ModelDto>> { IsSuccess = true, Data = modelsDtoo };
            }



        }
    }
}
