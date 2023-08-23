using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum Operation
    {
        [Description("TRUCK_TO_WAREHOUSE")]
        TRUCK_TO_WAREHOUSE = 1,
        [Description("TRUCK_TO_VESSEL")]
        TRUCK_TO_VESSEL,
        [Description("TRUCK_TO_TRUCK")]
        TRUCK_TO_TRUCK,
        [Description("WAREHOUSE_TO_TRUCK")]
        WAREHOUSE_TO_TRUCK,
        [Description("WAREHOUSE_TO_WAREHOUSE")]
        WAREHOUSE_TO_WAREHOUSE,
        [Description("WAREHOUSE_TO_VESSEL")]
        WAREHOUSE_TO_VESSEL,
        [Description("VESSEL_TO_TRUCK")]
        VESSEL_TO_TRUCK,
        [Description("VESSEL_TO_RAIL")]
        VESSEL_TO_RAIL,
        [Description("VESSEL_TO_WAREHOUSE")]
        VESSEL_TO_WAREHOUSE,
        [Description("RAIL_TO_VESSEL")]
        RAIL_TO_VESSEL,
        [Description("RAIL_TO_TRUCK")]
        RAIL_TO_TRUCK,
        [Description("RAIL_TO_WAREHOUSE")]
        RAIL_TO_WAREHOUSE

    }
}
