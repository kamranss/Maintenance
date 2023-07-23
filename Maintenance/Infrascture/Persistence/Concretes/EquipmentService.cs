using Application.Abstraction;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concretes
{
    public class EquipmentService : IEquipmentService
    {
        public List<Equipment> GetEquipment()
            => new()
        {
            new (){Id = 1, EquipmentName = "ForkLift"},
             new (){Id = 2, EquipmentName = "ForkLift"},
              new (){Id = 3, EquipmentName = "ForkLift"}
        };
    }
}
