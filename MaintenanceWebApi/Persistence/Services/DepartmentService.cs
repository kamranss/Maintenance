using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Repositories.DepartmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentReadRepository _readRepository;
        private readonly IDepartmentWriteRepository _writeRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentReadRepository readRepository, IDepartmentWriteRepository writeRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }

        public void CreateDepartment(DepartmentCreateDto product)
        {
            
        }

        public EquipmentGetDto Deatil(int? id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int? id)
        {
            throw new NotImplementedException();
        }

        public DepartmentGetDto FindDepartment(int? id)
        {
            var existDepartment = _readRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (existDepartment == null)
            {
                return null;
            }
            DepartmentGetDto departmentGetDto = new DepartmentGetDto();
            departmentGetDto.Name = existDepartment.Name;
            departmentGetDto.Description = existDepartment.Description;
            return departmentGetDto;
        }

        public Pagination<DepartmentGetDto> GetDepartment(int page, int take)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentGetDto> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public async Task<IServiceResult<Pagination<DepartmentListDto>>> GetDepartmentsAsync(int? page, int? pagesize)
        {
            if (!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0)
            {
                return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }

            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;

            var items = _readRepository
               .GetAll()
               .Skip(skipCount)
               .Take(takeValue)
               .Include(d => d.Equipments)
               .ToList();
            if (items == null)
            {
                return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
            var departmentListDto = _mapper.Map<List<DepartmentListDto>>(items);
            var paginatesDepartments = new Pagination<DepartmentListDto>(departmentListDto, pageValue, pageCount, totalCount);
            return  new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = true, Data = paginatesDepartments };
        }

        public Pagination<DepartmentGetDto> GetDepartmentsPortion(int page, int take)
        {
            throw new NotImplementedException();
        }

        public EquipmentGetDto IsDepartmentExist(int? id)
        {
            throw new NotImplementedException();
        }

        public Equipment MapDtoToEntity(EquipmentUpdateDto product)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveDepartmentImage(IFormFile newImage, Equipment equipment)
        {
            throw new NotImplementedException();
        }
    }
}
