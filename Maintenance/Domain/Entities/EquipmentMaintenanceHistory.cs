using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class EquipmentMaintenanceHistory
    {
       
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EquipmentId { get; set; }
        public Equipment? Equipment { get; set; }
        public int? PlanId { get; set; }
        public MaintenancePlan? MaintenancePlan { get; set; }
       
    }
}
