using Domain.Concrets;
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
        public bool? MpTime { get; set; }
        public int? Id { get; set; }      
        public string? Name { get; set; }   
        public string? Description { get; set; }     
        public string? OperationSite { get; set; }
        public int? ProductionYear { get; set; }
        public string? SeriaNumber { get; set; }    
        public string? Type { get; set; }
        public EquipmentStatus? Status { get; set; }
        //public Location? UsageLocation { get; set; } 
        //public string? Department { get; set; }      
        //public string? Manufacture { get; set; }     
        //public string Model { get; set; }
        public DateTime? LastMaintenace { get; set; }
        public decimal? CurrentValue { get; set; }


        //public int EquipmentTypeId { get; set; }
        //public int ManufactureId { get; set; }
        //public int DepartmentId { get; set; }
        //public int ModelId { get; set; }
        //public int OperationSiteid { get; set; }
        //public string? Model { get; set; }
        //[RegularExpression(@"^\d{4}$", ErrorMessage = "The production year must be a 4-digit number.")]
        //public string? UnitNumber { get; set; }
    }

}
