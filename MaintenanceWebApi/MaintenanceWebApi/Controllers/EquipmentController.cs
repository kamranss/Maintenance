using Application.Abstraction.Services;
using Application.Repositories.EquipmentRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IEquipmentReadRepository _equipmentReadRepository;
        private readonly IEquipmentWriteRepository _equipmentWriteRepository;

        public EquipmentController(IEquipmentService equipmentService, IEquipmentReadRepository equipmentReadRepository, IEquipmentWriteRepository equipmentWriteRepository)
        {
            _equipmentService = equipmentService;
            _equipmentReadRepository = equipmentReadRepository;
            _equipmentWriteRepository = equipmentWriteRepository;
        }

        [HttpGet]
        public IActionResult GetEquipments()
        {
            //var equipments = _equipmentService.GetEquipment();
            return Ok(equipments);
        }

      
    }
}
