using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsageHours
    {
        public int? UsageHourValue { get; set; }
        public DateTime? DateTime { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public int? EquipmentID { get; set; }
        public string? EquipmentName { get; set; }
    }
}
