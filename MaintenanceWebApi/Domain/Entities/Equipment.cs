using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Equipment:BaseEntity
    {
        public string? Name { get; set; }
        public string? UnitNumber { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Identification { get; set; }
        public string? Model { get; set; }
        public bool? isDeleted { get; set; }
        public string? Status { get; set; }
        //public IFormFile Image { get; set; }
        public int? OperationSiteid { get; set; }
        public string? ProductionYear { get; set; }
        public string MadeBy { get; set; }
        public string? SeriaNumber { get; set; }
        public int? Typeid { get; set; }
        public string? Capacity { get; set; }
        public string? EquipmentType { get; set; }
        public string? usageLocation { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<MaintenancePlan>? MaintenancePlan { get; set; }
        public List<Part>? Part { get; set; }
        //public List<EquipmentType> Type { get; set; }
        public List<OperationSite> OperationSite { get; set; }

    }
}
