using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MaintenanceAct:BaseEntity
    {
        public string? DocumentName { get; set; }
        public string? DocumentNumber { get; set; }
        public int? ConfirmedById { get; set; }
    }
}
