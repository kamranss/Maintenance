using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceCreateDto
    {
        public string? Name { get; set; }
        public string? ServiceType { get; set; } // Enum
        public string? ServiceDescription { get; set; }
        public int? MaintenancePlanId { get; set; } // table

        // when we create service we also should add Respective Plan Id which is selected at front side
    }
}
