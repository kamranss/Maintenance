using Domain.Common;
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
        public List<Equipment>? Equipments { get; set; }
        public List<Service>? Services { get; set; }
    }
}
