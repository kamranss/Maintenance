using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.MS
{
    public class MsSetDto
    {

        //public decimal? StartValue { get; set; }
        public decimal? SequenceValue { get; set; } // for instance 5000
        public int? MaintenancePlanId { get; set; }
        public int? EquipmentId { get; set; }

    }
}
