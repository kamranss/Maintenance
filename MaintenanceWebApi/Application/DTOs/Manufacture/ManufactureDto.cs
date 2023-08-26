using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Manufacture
{
    public class ManufactureDto:BaseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }
        //public string? RemovalReason { get; set; }
    }
}
