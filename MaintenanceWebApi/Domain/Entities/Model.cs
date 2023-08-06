using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model:BaseEntity
    {
        public string? Name { get; set; }
        public int? Code { get; set; }
        public string? RemovalReason { get; set; }
    }
}
