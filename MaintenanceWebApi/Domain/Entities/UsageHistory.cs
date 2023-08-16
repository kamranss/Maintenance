using Domain.Common;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsageHistory:BaseEntity
    {
        public int? EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public Operation? OperationName { get; set; }
        public int? StartUsageHourValue { get; set; }
        public int? EndUsageHourValue { get; set; }
        public string? OperatorName { get; set; }
        public int? TotalUsageValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TotalTime { get; set; }
        public string? Remark { get; set; }
        public Equipment Equipment { get; set; }
       
    }
}
