using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Department
{
    public class DepartmentUpdateDto
    {
        public int Id { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? DepartmentHead { get; set; }

    }
}
