using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsageHour:BaseEntity
    {
        public string Name { get; set; }
        public int? UsageHourValue { get; set; }
        public DateTime? DateTime { get; set; }
        public int? EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
    }
}
