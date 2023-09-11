using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentAndPart
    {

        public int? EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public string? PartName { get; set; }
        public int? PartId { get; set; }
    }
}
