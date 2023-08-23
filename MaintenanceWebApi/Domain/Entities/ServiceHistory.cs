using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ServiceHistory:BaseEntity
    {

        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
        public int? PartId { get; set; }
        public Part Part { get; set; }
        public string? WorkerName { get; set; }
    }
}
