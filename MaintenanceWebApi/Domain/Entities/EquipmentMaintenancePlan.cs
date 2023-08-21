using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EquipmentMaintenancePlan:BaseEntity
    {
        public int Id { get; set; }
        public int? EquipmentId { get; set; }
        public int? MaintenancePlanid { get; set; }
        public Equipment? Equipment { get; set; }
        public MaintenancePlan? MaintenancePlan { get; set; }
    }
}
