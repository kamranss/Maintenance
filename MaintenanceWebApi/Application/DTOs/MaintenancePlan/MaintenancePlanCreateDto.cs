﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.MaintenancePlan
{
    public class MaintenancePlanCreateDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }

        public string? MetricType { get; set; } // enum
    }
}
