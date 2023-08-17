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
        public int? EndUsageHourValue { get; set; }
        public int? TotalUsageValue { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
