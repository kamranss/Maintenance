using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Equipment:BaseEntity
    {
        public string? EquipmentName { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string? SeriaNumber { get; set; }
        public string? Capacity { get; set; }
        public string? EquipmentType { get; set; }
        public string? usageLocation { get; set; }
        public List<EquipmentPart>? Parts { get; set; }
    }
}
