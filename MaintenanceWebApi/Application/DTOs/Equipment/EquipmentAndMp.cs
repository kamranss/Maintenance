using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentAndMp
    {

        public int? EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public string? MpName { get; set; }
        public int? MpId { get; set; }
    }
}
