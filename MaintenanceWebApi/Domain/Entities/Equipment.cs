using Domain.Common;
using Domain.Concrets;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Equipment:BaseEntity
    {
        public string? Name { get; set; }

        public bool? IsIdle { get; set; }
        public string? UnitNumber { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Identification { get; set; }
        public int? ModelId { get; set; }
        public string? ImagUrl { get; set; }
        public int? OperationSiteid { get; set; }
        public int? ProductionYear { get; set; }
        public int? ManufactureId { get; set; }
        public string? SeriaNumber { get; set; }
        public string? Capacity { get; set; }
        public int? EquipmentTypeId { get; set; }
        public bool? IsNotified { get; set; } = false;
        public bool? MpCompleted { get; set; }
        public EquipmentStatus? Status { get; set; }
        public Location? usageLocation { get; set; }
        public DateTime? LastMaintenaceDate { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? ResetValue { get; set; }
        public decimal? SquenceValue { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<MaintenancePlan> MaintenancePlan { get; set; }
        public List<Part> Part { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public OperationSite OperationSite { get; set; }
        public Model Model { get; set; }
        public Manufacture Manufacture { get; set; }

        public List<UsageHistory> UsageHistories { get; set; }
        public List<MaintenanceSetting> MaintenanceSettings { get; set; }




        //public bool? isDeleted { get; set; }


        //[NotMapped]
        //public IFormFile Image { get; set; }

    }
}
