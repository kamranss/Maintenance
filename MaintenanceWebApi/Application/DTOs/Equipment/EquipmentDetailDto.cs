using Application.DTOs.MaintenancePlan;
using Application.DTOs.MS;
using Application.DTOs.Parts;
using Application.DTOs.UsageHistory;
using Domain.Concrets;
using Domain.Entities;
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
        public decimal? ResetValue { get; set; }
        public decimal? SquenceValue { get; set; }
        public List<MaintenancePlanDto>? MpList { get; set; }
        public List<MsDto>? SettingList { get; set; }
        public List<UsageHistoryDto>? UsageHistoryList { get; set; }
        public List<PartDto>? PartList { get; set; }
        public string? ImagUrl { get; set; }
        //public List<MsSetDto>? MaintenanceSettingsList { get; set; } 

        public EquipmentDetailDto()
        {
            MpList = new List<MaintenancePlanDto>();
            UsageHistoryList = new List<UsageHistoryDto>();
            PartList = new List<PartDto>();
            //MaintenanceSettingsList = new List<MsSetDto>(); 
        }
        

    }
}
