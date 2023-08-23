using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service
{
    public class ServiceHistoryDto
    {
        public int? ServiceId { get; set; }  
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? PartId { get; set; }
        public bool IsCompleted { get; set; }
        public string? WorkerName { get; set; }
    }
}
