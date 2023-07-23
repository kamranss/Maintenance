using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.EquipmentS
{
    public interface IEquipmentService
    {
        List<Equipment> GetEquipment();
    }
}
