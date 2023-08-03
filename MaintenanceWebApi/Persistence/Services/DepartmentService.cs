using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Repositories.DepartmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
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
