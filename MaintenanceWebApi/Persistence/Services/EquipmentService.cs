using Application.Abstraction.Services;
using Application.Repositories.EquipmentRepo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class EquipmentService
    {

        private readonly IEquipmentReadRepository _equipmentReadRepository;
        private readonly IEquipmentWriteRepository _equipmentWriteRepository;
        //readonly IQRCodeService _qrCodeService;
       

        public async Task CreateProductAsync()
        {

        }

    }
}
