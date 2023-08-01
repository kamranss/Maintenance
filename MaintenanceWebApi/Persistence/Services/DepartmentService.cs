using Application.DTOs.Department;
using Application.Repositories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class DepartmentService
    {
        IDepartmentReadRepository _readRepository;
        IDepartmentWriteRepository _writeRepository;

        public DepartmentService(IDepartmentReadRepository readRepository, IDepartmentWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task CreateDepartmentAsync(DepartmentCreateDto departmentCreateDto)
        {
            //var orderCode = (new Random().NextDouble() * 10000).ToString();
            //orderCode = orderCode.Substring(orderCode.IndexOf(".") + 1, orderCode.Length - orderCode.IndexOf(".") - 1);

            
            await _orderWriteRepository.AddAsync(new()
            {
                Address = createOrder.Address,
                Id = Guid.Parse(createOrder.BasketId),
                Description = createOrder.Description,
                OrderCode = orderCode
            });
            await _orderWriteRepository.SaveAsync();
        }
    }
}
