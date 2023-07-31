using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.Repositories.EquipmentRepo;
using Domain.Concrets;
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
            return Ok();
        }


        [HttpGet("EquipmentType")]
        public IActionResult GetEquipmentTypes()
        {
            var equipmentTypes = Enum.GetNames(typeof(EquipmentType)).ToList();
            return Ok(equipmentTypes);
        }


        [HttpPost("NewEquipment")]
        public IActionResult CreateEquipment([FromBody] EquipmentCreateDto equipmentCreateDto)
        {
            if (!string.IsNullOrEmpty(equipmentCreateDto.EquipmentType) &&
                
                Enum.TryParse<EquipmentType>(equipmentCreateDto.EquipmentType, out var equipmentType))
            {
               

                return Ok("Equipment created successfully!");
            }
            else
            {
              
                return BadRequest("Invalid equipment type selection.");
            }
        }


    }
}
