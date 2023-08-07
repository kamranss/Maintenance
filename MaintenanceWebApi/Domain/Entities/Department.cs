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
        public string? DepartmentHead { get; set; }
        public string? Description { get; set; }
        //public DateTime? RemovalDate { get; set; }
        public List<Equipment>? Equipments { get; set; }
    }
}
