using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum Operation
    {
        TRUCK_TO_WAREHOUSE,
        TRUCK_TO_VESSEL,
        TRUCK_TO_TRUCK,
        WAREHOUSE_TO_TRUCK,
        WAREHOUSE_TO_WAREHOUSE,
        WAREHOUSE_TO_VESSEL,
        VESSEL_TO_TRUCK,
        VESSEL_TO_RAIL,
        VESSEL_TO_WAREHOUSE,
        RAIL_TO_VESSEL,
        RAIL_TO_TRUCK,
        RAIL_TO_WAREHOUSE

    }
}
