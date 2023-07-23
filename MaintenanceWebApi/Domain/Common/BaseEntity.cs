using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? CreatedByid { get; set; }
        public int? ModifiedById { get; set; }
        //public AppUser Appuser { get; set; }
    }
}
