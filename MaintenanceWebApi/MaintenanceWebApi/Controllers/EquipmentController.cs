using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
using Application.Repositories.EquipmentRepo;
using Domain.Concrets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

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


      

        [HttpPost("NewEquipment")]
        public async Task<IActionResult> CreateEquipment([FromForm] EquipmentCreateDto equipmentCreateDto)
        {
            try
            {
                var result = await _equipmentService.CreateEquipment(equipmentCreateDto);

                if (result.IsSuccess)
                {
                    return Ok("Equipment created successfully.");
                }
                else
                {
                    return BadRequest(result.ErrorMessage);
                }
            }
            catch (EquipmentCreateException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("Type")]
        public IActionResult GetEquipmentTypes()
        {
            var equipmentTypes = Enum.GetNames(typeof(EquipmentType)).ToList();
            return Ok(equipmentTypes);
        }

        [HttpGet("Status")]
        public IActionResult GetEquipmentStatus()
        {
            var equipmentStatus = Enum.GetNames(typeof(EquipmentStatus)).ToList();
            return Ok(equipmentStatus);
        }

        [HttpGet("MetricType")]
        public IActionResult GetEquipmentMetricType()
        {
            var  metricType = Enum.GetNames(typeof(Metrictype)).ToList();
            return Ok(metricType);
        }

        [HttpGet("Location")]
        public IActionResult GetEquipmentLocation()
        {
            var location = Enum.GetNames(typeof(Location)).ToList();
            return Ok(location);
        }

    }
}
