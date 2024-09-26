using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Service:BaseEntity
    {
        public string? Name { get; set; }
        public string? ServiceType { get; set; }
        public string? ServiceDescription { get; set; }
        public int? MaintenancePlanId { get; set; }
        public int? PartId { get; set; }
        public string? PartName { get; set; }
        public Part? Part { get; set; }
        public bool IsPartChanged { get; set; }
        public MaintenancePlan? MaintenancePlan { get; set; }

        //public int? ChangedPartId { get; set; }
        //public EquipmentPart EquipmentPart { get; set; }
    }
}
