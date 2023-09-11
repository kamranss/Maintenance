using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentStatusDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public EquipmentStatus Status { get; set; }
    }
}
