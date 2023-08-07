﻿using Application.DTOs.Department;
using Application.DTOs.Equipment;
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
                .ForMember(ds => ds.ImagUrl, map => map.MapFrom(o => "https://localhost:7066/" + Guid.NewGuid())).ReverseMap();

            CreateMap<Equipment,EquipmentListDto>();

            CreateMap<Department, DepartmentListDto>();




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
