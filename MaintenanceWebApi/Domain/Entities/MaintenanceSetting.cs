using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MaintenanceSetting:BaseEntity
    {

        public string? MpName { get; set; }
        public decimal? StartValue { get; set; }// equ currect value
        public decimal? UpdatedValue { get; set; }
        public decimal? SequenceValue { get; set; } // for instance 5000
        public decimal?SsequencePeriod { get; set; } // will be set after each MP imlementation

        public DateTime? ResetDate { get; set; }
        public int? SequenceDateValue { get; set; }
        public int? DatePeriod { get; set; }
        public int? EquipmentId { get; set; }
        public int? MaintenancePlanId { get; set; }
        public bool IsMpCompleted { get; set; }
        public Equipment Equipment { get; set; }
        public MaintenancePlan MaintenancePlan { get; set; }

    }
}
