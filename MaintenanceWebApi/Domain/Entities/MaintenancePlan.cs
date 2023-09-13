using Domain.Common;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MaintenancePlan:BaseEntity
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public MaintenencePlanStatus? Status { get; set; }
        //public int MetricTypeId { get; set; }
        public Metrictype? MetricType { get; set; }
        public string? MetricTypeName { get; set; }
        //public int? MaintenanceSettingId { get; set; }
        public bool? MPChecked { get; set; } = true; // 
        public List<Equipment>? Equipments { get; set; }
        public List<Service>? Services { get; set; }
        public List<MaintenanceSetting>? MaintenanceSettings{ get; set; }
    }
}
