﻿using Application.DTOs.MaintenancePlan;
using Application.DTOs.Parts;
using Application.DTOs.UsageHistory;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Equipment
{
    public class EquipmentDetailDto
    {
        public bool? MpTime { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? OperationSite { get; set; }
        public int? ProductionYear { get; set; }
        public string? SeriaNumber { get; set; }
        public string? Type { get; set; }
        public EquipmentStatus? Status { get; set; }
        public Location? UsageLocation { get; set; }
        public string? Department { get; set; }
        public string? Manufacture { get; set; }
        public string Model { get; set; }
        public DateTime? LastMaintenace { get; set; }
        public decimal? CurrentValue { get; set; }
        public List<MaintenancePlanDto>? MpList { get; set; }
        public List<UsageHistoryDto>? UsageHistoryList { get; set; }
        public List<PartDto>? PartList { get; set; }
    }
}