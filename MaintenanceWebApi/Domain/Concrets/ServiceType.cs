using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum ServiceType
    {
        [Description("CALIBRATION")]
        CALIBRATION = 1,
        [Description("FIX")]
        FIX,
        [Description("INSPECTION")]
        INSPECTION,
        [Description("REFILL")]
        REFILL,
        [Description("REPLACE")]
        REPLACE
    }
}
