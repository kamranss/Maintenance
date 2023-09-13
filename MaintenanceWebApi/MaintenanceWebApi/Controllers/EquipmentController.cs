using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
using Application.Repositories.EquipmentRepo;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        //[Authorize]
        [HttpGet]
        public IActionResult GetEquipment(int? id)
        {
            var result = _equipmentService.FindEquipmentAsync(id).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipments(int? pageSize, int? pageNumber)
        {

           var result =  _equipmentService.GetEquipmentsAsync(pageSize, pageNumber).Result;
            if (result.IsSuccess == true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.ErrorMessage);
           
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



        [HttpGet("FindEquipmentsByDepartmentId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentsByDepartment(int? page, int? pageSize, int id)
        {
            var result = _equipmentService.FindByDepartmentId(page, pageSize, id).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);
        }

        [Route("StatusChange")]
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ChangeStatus([FromForm]int id, [FromForm] EquipmentStatus newStatus)
        {

            var result = _equipmentService.ChangeEquipmentStatusAsync(id, newStatus).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);
        }


  
        [HttpPost("AddMpToEquipment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddMpToEquipment([FromForm]int equipmentId,[FromForm] int mpid)
        {
            var result = await _equipmentService.AddMptoEquipment(equipmentId, mpid);

            if (result.IsSuccess)
            {
                return Ok("Mp added");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }

        [HttpPost("AddPartToEquipment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddPartToEquipment([FromForm] int equipmentId, [FromForm] int partId)
        {
            var result = await _equipmentService.AddParttoEquipment(equipmentId, partId);

            if (result.IsSuccess)
            {
                return Ok("Part added");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }

        [HttpGet("DropDown")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentsforInput(string? name)
        {
            var result = _equipmentService.GetEquipmentsForInput(name).Result;
            return Ok(result.Data);

        }



    }
}
