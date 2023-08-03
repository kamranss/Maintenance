﻿using Application.DTOs.Equipment;
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
        //CreateMap<Equipment, EquipmentDto>() // we can use reverse map to change back the mapping
        //        .ForMember(mc => mc.ImageUrl, map => map.MapFrom(c => "https://localhost:7268/" + c.ImagUrl))
        //        .ForMember(ds => ds.ProductsCount, map => map.MapFrom(c => c.Products.Count)); // this approach works when property names are not same


        //CreateMap<Department, Depar>()
        //        .ForMember(ds => ds.ProductCount, map => map.MapFrom(c => c.Products.Count)); // we are doing it because of types are different within mapped objects


        //    CreateMap<Product, ProductReturnDto>()
        //        .ForMember(ds => ds.Profit, map => map.MapFrom(p => p.SalePrice - p.CostPrice));
        //    // if two objects having property with same name but types are different the automapper will provide missingType error for client

        //    CreateMap<AppUser, UserReturnDto>()
        //        .ForMember(ds => ds.Age, map => map.MapFrom(u => u.BirthDay.BirthdayToAge())); // using extenion method to find age of user
    }
}