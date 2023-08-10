    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceUpdateDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? ServiceType { get; set; } // Enum
        public string? ServiceDescription { get; set; }
    }
}
