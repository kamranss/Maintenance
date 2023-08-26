
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
        ACTIVE = 1,
        [Description("INACTIVE")]
        INACTIVE = 2,
        [Description("REPAIR")]
        REPAIR = 3,
        [Description("IN_USE")]
        IN_USE = 4,
        [Description("CONCERVATED")]
        CONCERVATED = 5,
   
    }
}
