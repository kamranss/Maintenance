using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.Model;
using Application.Repositories.DepartmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
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
        private IMemoryCache _memoryCach;

        public DepartmentService(IDepartmentReadRepository readRepository, IDepartmentWriteRepository writeRepository, IMapper mapper, IMemoryCache memoryCach)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
        }


        public async Task<IServiceResult<DepartmentCreateDto>> CreateDepartmentAsync(DepartmentCreateDto department)
        {
            var newDepartment = _mapper.Map<Department>(department);
            newDepartment.IsActive = true;
            newDepartment.IsDeleted = true;
           
            var isSameDepartmentExist = _readRepository.GetWhere(d => d.Name == newDepartment.Name).Any();
            if (isSameDepartmentExist)
            {
                return new ServiceResult<DepartmentCreateDto> { IsSuccess = false, ErrorMessage = "Same Department already exist" };
            }
            var result = await _writeRepository.AddAsync(newDepartment);
            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();

                if (endresult > 0)
                {
                    var mappedDepartment = _mapper.Map<DepartmentCreateDto>(newDepartment);

                    List<DepartmentCachedDto> cachedDepartments;
                    bool DepartmentsAlreadyExist = _memoryCach.TryGetValue("CachedDepartments", out cachedDepartments);
                    if (!DepartmentsAlreadyExist)
                    {
                        //var EquipmentsFromDb = _equipmentReadRepository.GetWhere(e => e.Id == newEquipment.Id);
                        var departmentsFromDb = _readRepository.GetAll(tracking: false).ToList();


                        var cachEntryOption = new MemoryCacheEntryOptions()
                            .SetSlidingExpiration(TimeSpan.FromDays(10));
                        _memoryCach.Set("CachedEquipmentss", departmentsFromDb, cachEntryOption);
                    }
                    else
                    {

                        var departments = cachedDepartments;

                        var newlyAdedDepartmen = _readRepository.GetWhere(d => d.Name == newDepartment.Name).ToList();
                        if (newlyAdedDepartmen != null)
                        {
                            var mappedDepartmentToCache = _mapper.Map<DepartmentCachedDto>(newlyAdedDepartmen);
                            departments.Add(mappedDepartmentToCache);

                            // Update the cache with the updated products list
                            var cacheEntryOptions = new MemoryCacheEntryOptions()
                                .SetSlidingExpiration(TimeSpan.FromDays(10));
                            _memoryCach.Set("CachedEquipmentss", departments, cacheEntryOptions);
                        }
                    }

                    return new ServiceResult<DepartmentCreateDto> { IsSuccess = true, Data = mappedDepartment };
                }
                return new ServiceResult<DepartmentCreateDto> { IsSuccess = false, ErrorMessage = "Department could not be saved." };
            }

            return new ServiceResult<DepartmentCreateDto> { IsSuccess = false, ErrorMessage = "Department could not be added." };

        } // done

        public EquipmentGetDto Deatil(int? id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int? id)
        {
            throw new NotImplementedException();
        }// will not use 

        public async Task<IServiceResult<DepartmentDto>> DeleteDepartmentAsync(int id)
        {
            if (id==null && id<=0)
            {
                return new ServiceResult<DepartmentDto> { IsSuccess = false, ErrorMessage = "The id should not be null" };
            }

            var existDepartment = await _readRepository.GetByIdAsync(id);

            if (existDepartment==null)
            {
                return new ServiceResult<DepartmentDto> { IsSuccess = false, ErrorMessage = "The department not found" };
            }
            var result = _writeRepository.Remove(existDepartment);
            if (result == true)
            {
               await _writeRepository.SaveAsync();
                var mappedDepartment = _mapper.Map<DepartmentDto>(existDepartment);
                return new ServiceResult<DepartmentDto> { IsSuccess = true, Data = mappedDepartment };
            }
            return new ServiceResult<DepartmentDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        } // done

        public async Task<IServiceResult<DepartmentListDto>> FindDepartmentAsync(int? id)
        {
            if (!id.HasValue && id <= 0)
            {
                return new ServiceResult<DepartmentListDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existDepartment = _readRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (existDepartment == null)
            {
                return new ServiceResult<DepartmentListDto> { IsSuccess = false, ErrorMessage = "There is no department with this Id" };
            }
            var departmentListDto = _mapper.Map<DepartmentListDto>(existDepartment);

            return new ServiceResult<DepartmentListDto> { IsSuccess = true, Data = departmentListDto };
        }// done

        public async Task<IServiceResult<Pagination<DepartmentListDto>>> GetDepartmentsAsync(int? page, int? pagesize)
        {
      
            if (page == null && pagesize == null)
            {
                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt/2;

                 var deps = _readRepository
                .GetAll()
                .Take(takeValuee)
                .Include(d => d.Equipments)
                .Where(d => d.IsDeleted == false)
                .ToList();

                if (deps == null)
                {
                    return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Department in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var departmentListDtoo = _mapper.Map<List<DepartmentListDto>>(deps);
                var paginatesDepartmentss = new Pagination<DepartmentListDto>(departmentListDtoo, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = true, Data = paginatesDepartmentss };


            }


            if (!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0)
            {
                return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            var count = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;

            var items = _readRepository
               .GetAll()
               .Skip(skipCount)
               .Take(takeValue)
               .Include(d => d.Equipments)
               .Where(d => d.IsDeleted == false)
               .ToList();
            if (items == null)
            {
                return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }
            var totalCount = count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
            var departmentListDto = _mapper.Map<List<DepartmentListDto>>(items);
            var paginatesDepartments = new Pagination<DepartmentListDto>(departmentListDto, pageValue, pageCount, totalCount);
            return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = true, Data = paginatesDepartments };
        } // done

        public EquipmentGetDto IsDepartmentExist(int? id)
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
        } // will not use this one

        public async Task<IServiceResult<DepartmentUpdateDto>> UpdateDepartmentAsync(DepartmentUpdateDto department)
        {

            var existDepartment = _readRepository.GetWhere(d => d.Id == department.Id).FirstOrDefault();
            if (existDepartment == null)
            {
                return new ServiceResult<DepartmentUpdateDto> { IsSuccess = false, ErrorMessage = "Department not found" };
            }

            var checkDepartmentName = _readRepository.GetWhere(d => d.Name == department.Name).Any();
            if ( _readRepository.GetWhere(d => d.Name.ToLower() == department.Name.ToLower() && d.Id != department.Id).Any())
            {
                return new ServiceResult<DepartmentUpdateDto> { IsSuccess = false, ErrorMessage = "Same Department already exist you should pick another Name" };
            }

            existDepartment.Name = department.Name;
            existDepartment.Description = department.Description;

            _writeRepository.Update(existDepartment);
            _writeRepository.SaveAsync();



            List<DepartmentCachedDto> cachedDepartments;
            bool DepartmentsAlreadyExist = _memoryCach.TryGetValue("CachedDepartments", out cachedDepartments);
            if (!DepartmentsAlreadyExist)
            {
                //var EquipmentsFromDb = _equipmentReadRepository.GetWhere(e => e.Id == newEquipment.Id);
                var departmentsFromDb = _readRepository.GetAll(tracking: false).ToList();
                
                var cachEntryOption = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromDays(10));
                _memoryCach.Set("CachedEquipmentss", departmentsFromDb, cachEntryOption);
            }
            else
            {

             

                var updatedCachedDepartment = cachedDepartments.Where(d => d.Id == department.Id).FirstOrDefault();
                updatedCachedDepartment.Name = department.Name;
                updatedCachedDepartment.Description = department.Description;

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                         .SetSlidingExpiration(TimeSpan.FromDays(10));
                _memoryCach.Set("CachedEquipmentss", cachedDepartments, cacheEntryOptions);
            }

            return new ServiceResult<DepartmentUpdateDto> { IsSuccess = true, Data = department };
        } // done

        public async Task<IServiceResult<List<DepartmentDto>>> GetDepartmentsForInput(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                var deps = _readRepository.GetAll().Take(5);
                if (deps == null)
                {
                    return new ServiceResult<List<DepartmentDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = deps.ToList();
                var depsDto = _mapper.Map<List<DepartmentDto>>(itemss);
                return new ServiceResult<List<DepartmentDto>> { IsSuccess = true, Data = depsDto };
            }
            else
            {
                var departments = _readRepository.GetAll().Where(m => m.Name.ToLower().Contains(name));
                if (departments == null)
                {
                    return new ServiceResult<List<DepartmentDto>> { IsSuccess = true, Data = new List<DepartmentDto>() };
                }
                var itemsss = departments.ToList();
                var depssDto = _mapper.Map<List<DepartmentDto>>(itemsss);
                return new ServiceResult<List<DepartmentDto>> { IsSuccess = true, Data = depssDto };
            }
        }
    }

        

        //public async Task<IServiceResult<DepartmentListDto>> FindDepartmentAsync(int? id)
        //{
        //    if (!id.HasValue && id<=0)
        //    {
        //        return new ServiceResult<DepartmentListDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
        //    }
        //    var existDepartment = _readRepository.GetAll().FirstOrDefault(d => d.Id == id);
        //    if (existDepartment == null)
        //    {
        //        return new ServiceResult<DepartmentListDto> { IsSuccess = false, ErrorMessage = "There is no department with this Id" };
        //    }
        //    var departmentListDto = _mapper.Map<DepartmentListDto>(existDepartment);

        //    return new ServiceResult<DepartmentListDto> { IsSuccess = true, Data = departmentListDto };
        //} // done

        //public async Task<IServiceResult<Pagination<DepartmentListDto>>> GetDepartmentsAsync(int? page, int? pagesize)
        //{
        //    if (!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0)
        //    {
        //        return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
        //    }

        //    int pageValue = page.Value;
        //    int takeValue = pagesize.Value;
        //    int skipCount = (pageValue - 1) * takeValue;

        //    var items = _readRepository
        //       .GetAll()
        //       .Skip(skipCount)
        //       .Take(takeValue)
        //       .Include(d => d.Equipments)
        //       .Where(d => d.IsDeleted==false)
        //       .ToList();
        //    if (items == null)
        //    {
        //        return new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
        //    }
        //    var totalCount = items.Count;
        //    var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
        //    var departmentListDto = _mapper.Map<List<DepartmentListDto>>(items);
        //    var paginatesDepartments = new Pagination<DepartmentListDto>(departmentListDto, pageValue, pageCount, totalCount);
        //    return  new ServiceResult<Pagination<DepartmentListDto>> { IsSuccess = true, Data = paginatesDepartments };
        //} // done 


     
    
}
