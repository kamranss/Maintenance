using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Repositories.DepartmentRepo;
using Application.RequestParameters;
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
        IDepartmentReadRepository _readRepository;
        IDepartmentWriteRepository _writeRepository;

        public DepartmentService(IDepartmentReadRepository readRepository, IDepartmentWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public void CreateDepartment(DepartmentCreateDto product)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Pagination<DepartmentGetDto> GetDepartment(int page, int take)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentGetDto> GetDepartments()
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
