using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UsageHistory
{
    public class UsageHistoryCreateDto
    {
        public int? EquipmentId { get; set; }
        //public string? EquipmentName { get; set; }
        public Operation? OperationName { get; set; }
        //public decimal? StartUsageHourValue { get; set; }

        public string? OperatorName { get; set; }

        public DateTime? StartDate { get; set; }
        public string? Remark { get; set; }
        //public DateTime? EndDate { get; set; }
        //public decimal? TotalTime { get; set; }
     
   
    }
}
