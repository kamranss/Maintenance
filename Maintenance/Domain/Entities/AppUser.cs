using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? OTP { get; set; }
        public bool? IsActive { get; set; }
        public string? ConnectionId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
