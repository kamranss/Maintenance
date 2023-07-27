using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentCreateDto
    {
        public string? Name { get; set; }
        public string? UnitNumber { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Identification { get; set; }
        public string? Model { get; set; }
        public int? OperationSiteid { get; set; }
        public DateOnly? ProductionYear { get; set; }
        public string MadeBy { get; set; }
        public string? SeriaNumber { get; set; }
        public int? Typeid { get; set; }
        public string? Capacity { get; set; }
        public string? EquipmentType { get; set; }
        public string? usageLocation { get; set; }
        public int? DepartmentId { get; set; }

    }
}
