using Application.Abstraction.EquipmentS;
using Application.Abstraction.Services;
using Application.Repositories.EquipmentRepo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class EquipmentService : IEquipmentService
    {

        private readonly IEquipmentReadRepository _equipmentReadRepository;
        private readonly IEquipmentWriteRepository _equipmentWriteRepository;
        readonly IQRCodeService _qrCodeService;
        public Task<byte[]> QrCodeToProductAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task StockUpdateToProductAsync(string productId, int stock)
        {
            throw new NotImplementedException();
        }


    }
}
