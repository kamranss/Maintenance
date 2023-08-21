using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UsageHistory
{
    public class UsageHistoryEndDto
    {
        public int? UsageHistoryId { get; set; }
        public decimal? EndUsageHourValue { get; set; }
        //public decimal? TotalUsageValue { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
