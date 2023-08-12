using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.DTOs.UsageHistory;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.UsageHistoryRepo;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class UsageHistoryService : IUsageHistoryService
    {
        private readonly IUsageHistoryReadRepository _readRepository;
        private readonly IUsageHistoryWriteRepository _writeRepository;
        private readonly IEquipmentReadRepository _equipmentReadRepository;

        public UsageHistoryService(IUsageHistoryReadRepository readRepository, IUsageHistoryWriteRepository writeRepository, IEquipmentReadRepository equipmentReadRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _equipmentReadRepository = equipmentReadRepository;
        }

        public async Task<IServiceResult<UsageHistoryCreateDto>> CreateUsageHistoryAsync(UsageHistoryCreateDto usageHistoryCreate)
        {
            if (!usageHistoryCreate.EquipmentId.HasValue && usageHistoryCreate.EquipmentId <= 0)
            {
                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existEquipment = _equipmentReadRepository.GetAll().FirstOrDefault(d => d.Id == usageHistoryCreate.EquipmentId);
            if (existEquipment == null)
            {
                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }


            //var equipmentListDto = _mapper.Map<EquipmentListDto>(existEquipment);

            return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = true, Data = usageHistoryCreate };
        }

        public Task<IServiceResult<UsageHistoryEndDto>> EndUsageHistoryAsync(UsageHistoryEndDto usageHistoryEnd)
        {
            throw new NotImplementedException();
        }

        public Task<IServiceResult<UsageHistoryDto>> FindEquipmentUSageAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
