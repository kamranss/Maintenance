using Application.DTOs.Common;
using Application.DTOs.Equipment;
using Application.DTOs.Service;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.MaintenancePlan
{
    public class MpDto
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //public bool? IsActive { get; set; }
        public MaintenencePlanStatus? Status { get; set; }
        public Metrictype? MetricType { get; set; }
        //public List<EquipmentDto>? Equipments { get; set; }
        //public List<ServiceDto>? Services { get; set; }
    }
}
