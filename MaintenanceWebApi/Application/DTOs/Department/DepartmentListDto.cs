﻿using Application.DTOs.Common;
using Application.DTOs.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Department
{
    public class DepartmentListDto:BaseDto
    {
        public string? Name { get; set; }
        public string? DepartmentHead { get; set; }
        public string? Description { get; set; }
        public List<EquipmentListDto>? Equipments { get; set; }
    }
}
