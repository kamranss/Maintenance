using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum MaintenencePlanStatus
    {
        [Description("STARTED")]
        STARTED = 1,
        [Description("PENDING")]
        PENDING = 2,
        [Description("COMPLETED")]
        COMPLETED = 3

    }
}
