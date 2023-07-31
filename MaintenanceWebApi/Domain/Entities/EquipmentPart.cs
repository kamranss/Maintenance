using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EquipmentPart:BaseEntity
    {
        public int? EquipmentId { get; set; }
        public int? PartId { get; set; }
        public Equipment? Equipment { get; set; }
        public Part? Part { get; set; }
    }
}
