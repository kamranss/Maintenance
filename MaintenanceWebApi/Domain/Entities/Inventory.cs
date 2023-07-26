using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inventory:BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int SeriaNumber { get; set; }
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }
        public int LimitforOrder { get; set; }
        public decimal Price { get; set; }
        public string Factory { get; set; }
     
    }
}
