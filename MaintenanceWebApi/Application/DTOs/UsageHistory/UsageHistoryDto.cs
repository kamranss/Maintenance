using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UsageHistory
{
    public class UsageHistoryDto:BaseDto
    {
        public string? EquipmentName { get; set; }
        public string? OperationName { get; set; }
        public int? StartUsageHourValue { get; set; }
        public int? EndUsageHourValue { get; set; }
        public string? OperatorName { get; set; }
        public int? TotalUsageValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TotalTime { get; set; }
        public int? EquipmentId { get; set; }
    }
}
