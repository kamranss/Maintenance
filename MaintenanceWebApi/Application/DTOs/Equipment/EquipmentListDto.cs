using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentListDto
    {
        public string? Status { get; set; }
        public string? Name { get; set; }
        //public string? UnitNumber { get; set; }
        public string? Description { get; set; }
        public string? Model { get; set; }
        public int? OperationSiteid { get; set; }

        //[RegularExpression(@"^\d{4}$", ErrorMessage = "The production year must be a 4-digit number.")]
        public int? ProductionYear { get; set; }
        public string? SeriaNumber { get; set; }
        public string? EquipmentType { get; set; }
        public string? UsageLocation { get; set; }
        public int? DepartmentId { get; set; }
        public int? ManufactureId { get; set; }
        public int? ModelId { get; set; }
        public DateTime? LastMaintenace { get; set; }
        public decimal? CurrentValue { get; set; }
    }
}
