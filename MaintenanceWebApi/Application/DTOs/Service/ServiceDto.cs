using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceDto:BaseEntity
    {
        public string? Name { get; set; }
        public string? ServiceType { get; set; } // enum
        public string? ServiceDescription { get; set; }
        public int? MaintenancePlanId { get; set; }
        public int? ChangedPartId { get; set; }

    }
}
