using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppUser:IdentityUser
    {
      
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? OTP { get; set; }
        public bool IsActive { get; set; }
        public bool? IsOperator { get; set; }
        public bool? IsDivisionHead { get; set; }
        public string? ConnectionId { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
