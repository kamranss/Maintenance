using Domain.Concrets;
using System;
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
        public string? Description { get; set; }
        public Metrictype? MetricType { get; set; } // enum
    }
}
