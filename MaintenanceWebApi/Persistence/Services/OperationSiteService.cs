﻿using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Manufacture;
using Application.DTOs.Model;
using Application.DTOs.OperationSite;
using Application.DTOs.Parts;
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
            if (page == null || pageSize == null)
            {

                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt;

                var partss = _readRepository.GetAll();

                if (partss == null)
                {
                    return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = partss.ToList();
                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var partsDto = _mapper.Map<List<OperationSiteDto>>(itemss);

                var paginationn = new Pagination<OperationSiteDto>(partsDto, pageValuee, pageCountt, totalCountt);

                return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = true, Data = paginationn };
            }
            if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
            {
                return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }

            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            //int skip = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;
            var parts = _readRepository.GetAll(tracking: false);

            var items = parts
                    .Skip((pageValue - 1) * takeValue)
                    .Take(takeValue)
                    .Where(e => e.IsDeleted == false && e.IsActive == true)
                    .ToList();


            if (items == null)
            {
                return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "There is no parts in DB" };
            }
            var totalCount = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count(); ;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var partsDtoo = _mapper.Map<List<OperationSiteDto>>(items);
            var pagination = new Pagination<OperationSiteDto>(partsDtoo, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = true, Data = pagination };
        }
    }
}



//public async Task<IServiceResult<Pagination<OperationSiteDto>>> GetOperationSitesAsync(int? page, int? pageSize)
//{
//    if (page == null && pageSize == null)
//    {
//        //int pageValue = page.Value;
//        //int takeValue = pageSize.Value;
//        //int skipCount = (pageValue - 1) * takeValue;


//        var operationSite = _readRepository.GetAll();

//        if (operationSite == null)
//        {
//            return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
//        }
//        var items = operationSite.ToList();

//        var totalCount = items.Count;
//        //var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
//        var manufactureDto = _mapper.Map<List<OperationSiteDto>>(items);

//        var pagination = new Pagination<OperationSiteDto>(manufactureDto, 0, 0, totalCount);

//        return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = true, Data = pagination };
//    }
//    if ((!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0))
//    {
//        return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
//    }


//    return new ServiceResult<Pagination<OperationSiteDto>> { IsSuccess = false, ErrorMessage = "SomeThing Went wrong" };
//}