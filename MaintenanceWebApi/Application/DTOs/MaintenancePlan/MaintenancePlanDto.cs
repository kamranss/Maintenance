using Application.DTOs.Equipment;
using Application.DTOs.Service;
using Domain.Common;
using Domain.Concrets;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.MaintenancePlan
{
    public class MaintenancePlanDto:BaseEntity
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public MaintenencePlanStatus? Status { get; set; }
        public Metrictype? MetricType { get; set; } // inum
        public List<EquipmentDto>? Equipments { get; set; }
        public List<ServiceDto>? Services { get; set; }
    }
}
