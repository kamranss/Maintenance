using Application.DTOs.Common;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UsageHistory
{
    public class UsageHistoryDto
    {
        public int Id { get; set; }
        public string? EquipmentName { get; set; }
        public string? OperationName { get; set; }
        public decimal? StartUsageHourValue { get; set; }
        public decimal? EndUsageHourValue { get; set; }
        public string? OperatorName { get; set; }
        public decimal? TotalUsageValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public UsageHistoryStatus Status { get; set; }
        public decimal? TotalTime { get; set; }
        //public int? EquipmentId { get; set; }
    }
}
