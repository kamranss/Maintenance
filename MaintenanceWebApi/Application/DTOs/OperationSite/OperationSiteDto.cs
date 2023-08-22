using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.OperationSite
{
    public class OperationSiteDto:BaseEntity
    {
        //public int? Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string? Department { get; set; }
        public int? DepartmentId { get; set; }

    }
}
