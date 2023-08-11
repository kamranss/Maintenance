using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Application.DTOs.UsageHistory;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<EquipmentCreateDto, Equipment>()
                .ForMember(ds => ds.ImagUrl, map => map.MapFrom(o => "https://localhost:7066/" + Guid.NewGuid())).ReverseMap(); //  should be fixed
            CreateMap<Equipment,EquipmentListDto>();
            CreateMap<EquipmentCachedDto, EquipmentListDto>().ReverseMap();



            CreateMap<Department, DepartmentListDto>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<Department, DepartmentCreateDto>().ReverseMap();
            CreateMap<Department, DepartmentUpdateDto>().ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore());

            CreateMap<Department, DepartmentCachedDto>().ReverseMap();


            CreateMap<Service, ServiceDto>();
            CreateMap<ServiceCreateDto, Service>();
            CreateMap<ServiceUpdateDto, Service>();


            CreateMap<MaintenancePlan, MaintenancePlanDto>();
            CreateMap<MaintenancePlanCreateDto, MaintenancePlan>();
            CreateMap<MaintenancePlanUpdateDto, MaintenancePlan>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore());

   
            CreateMap<UsageHistory, UsageHistoryDto>().ReverseMap();
            CreateMap<UsageHistoryCreateDto, UsageHistory>();





            //CreateMap<Department, Depar>()
            //        .ForMember(ds => ds.ProductCount, map => map.MapFrom(c => c.Products.Count)); // we are doing it because of types are different within mapped objects


            //    CreateMap<Product, ProductReturnDto>()
            //        .ForMember(ds => ds.Profit, map => map.MapFrom(p => p.SalePrice - p.CostPrice));
            //    // if two objects having property with same name but types are different the automapper will provide missingType error for client

            //    CreateMap<AppUser, UserReturnDto>()
            //        .ForMember(ds => ds.Age, map => map.MapFrom(u => u.BirthDay.BirthdayToAge())); // using extenion method to find age of user
        }
    }
}
