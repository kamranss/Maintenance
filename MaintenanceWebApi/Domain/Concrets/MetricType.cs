using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum Metrictype
    {
        [Description("PERIOD")]
        PERIOD =1,
        [Description("MOTO_HOURS")]
        MOTO_HOURS =2,
        [Description("WEIGHT")]
        WEIGHT =3,
        [Description("DISTANCE")]
        DISTANCE =4,
        [Description("UNPLANNED")]
        UNPLANNED = 5
    }
}
