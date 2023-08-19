
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum EquipmentStatus
    {
        [Description("ACTIVE")]
        ACTIVE = 0,
        [Description("INACTIVE")]
        INACTIVE = 1,
        [Description("REPAIR")]
        REPAIR = 2,
        [Description("ACTIVE")]
        IN_USE = 3,
        [Description("CONCERVATED")]
        CONCERVATED = 4,
   
    }
}
