using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.MS
{
    public class MpCompleted
    {
        public int? MaintenancePlanId { get; set; }
        public int? EquipmentId { get; set; }
        public int? EquSettingid { get; set; }
    }
}
