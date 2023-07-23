using Application.Abstraction.EquipmentS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concretes.Equipment
{
    public class EquipmentService : IEquipmentService
    {
        public List<Domain.Entities.Equipment> GetEquipment()
            => new()
        {
            new (){Id = 1, EquipmentName = "ForkLift"},
             new (){Id = 2, EquipmentName = "ForkLift"},
              new (){Id = 3, EquipmentName = "ForkLift"}
        };
    }
}
