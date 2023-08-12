using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentUpdateDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? UnitNumber { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Identification { get; set; }
        public string? Model { get; set; }
        public int? OperationSiteid { get; set; }

        //[RegularExpression(@"^\d{4}$", ErrorMessage = "The production year must be a 4-digit number.")]
        public int? ProductionYear { get; set; }
        public string MadeBy { get; set; }
        public string? SeriaNumber { get; set; }
        public int? Typeid { get; set; }
        public string? Capacity { get; set; }
        public string? EquipmentType { get; set; }
        public Location? usageLocation { get; set; }
        public int? DepartmentId { get; set; }
    }
}
