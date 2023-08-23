using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum UsageHistoryStatus
    {
        [Description("Ongoing")]
        ONGOING = 1,
        [Description("Finished")]
        FINISHED = 2,
        [Description("Canceled")]
        CANCELED = 3,
    }
}
