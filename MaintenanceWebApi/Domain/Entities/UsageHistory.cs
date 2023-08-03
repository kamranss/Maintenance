using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsageHistory:BaseEntity
    {
        public string? Name { get; set; }
        public int? Description { get; set; }
        public int? StartUsageHourValue { get; set; }
        public int? EndUsageHourValue { get; set; }
        public string? Operator { get; set; }
        public int? UsageHourValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public string? EquipmentName { get; set; }
    }
}
