using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Department:BaseEntity
    {
        public string? Name { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public List<Equipment>? Equipments { get; set; }
    }
}
