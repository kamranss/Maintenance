using Application.Abstraction.Services;
using Application.DTOs.Department;
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


        [HttpPost("NewEquipment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateEquipment([FromForm] EquipmentCreateDto equipmentCreateDto)
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
            //try
            //{
               
            //}
            //catch (EquipmentCreateException ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet]
        public IActionResult GetEquipment(int? id)
        {
            var department = _equipmentService.FindEquipmentAsync(id);
            return Ok(department);
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipments(int pageSize, int pageNumber)
        {
           var equipments =  _equipmentService.GetEquipmentsAsync(pageSize, pageNumber);
            return Ok(equipments);
        }


        [HttpGet("Status")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentStatus()
        {
            var equipmentStatus = Enum.GetNames(typeof(EquipmentStatus)).ToList();
            return Ok(equipmentStatus);
        }

        [HttpGet("MetricType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentMetricType()
        {
            var  metricType = Enum.GetNames(typeof(Metrictype)).ToList();
            return Ok(metricType);
        }

        [HttpGet("Location")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentLocation()
        {
            var location = Enum.GetNames(typeof(Location)).ToList();
            return Ok(location);
        }

        [Route("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            var result = await _equipmentService.DeleteEquipmentAsync(id);
            if (result.IsSuccess == true)
            {
                return Ok("Equipment Deleted succesfully");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }

        [Route("ModEqipment")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(EquipmentUpdateDto equipmentUpdateDto)
        {
            _equipmentService.UpdateEquipemntAsync(equipmentUpdateDto);

            return StatusCode(200, "EquipmentUpdated Updated");
        }

        [HttpGet("EquipmentUsageHistory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentUsageHistory(int? pageSize, int? pageNumber, int id)
        {
            var usageHistory = _equipmentService.GetUsageHistoryByEquipmentIdAsync(pageSize, pageNumber, id);
            return Ok(usageHistory);
        }


        [Route("StatusChange")]
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(int id, string newStatus)
        {
            _equipmentService.ChangeEquipmentStatusAsync(id, newStatus);

            return StatusCode(200, "Status Updated");
        }



    }
}
