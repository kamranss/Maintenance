using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenancePlanController : ControllerBase
    {
        private readonly IMPService _mpService;

        public MaintenancePlanController(IMPService mpService)
        {
            _mpService = mpService;
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMPs(int page, int pageSize)
        {
            var Mps = _mpService.GetMPsAsync(page, pageSize);
            return Ok(Mps);
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMpServices(int? page, int? pageSize, int? id)
        {
            var Services = _mpService.FindServicesByMPidAsync(page,pageSize,id);
            return Ok(Services);
        }


        [HttpPost("NewMP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateDepartment(MaintenancePlanCreateDto maintenancePlanCreateDto)
        {
            var result = await _mpService.CreateMPAsync(maintenancePlanCreateDto);

            if (result.IsSuccess)
            {
                return Ok("Mp created successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }


        [Route("ModMP")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(MaintenancePlanUpdateDto maintenancePlanUpdateDto)
        {
            await _mpService.UpdateMPAsync(maintenancePlanUpdateDto);
            return StatusCode(200, "Mp Updated");
        }


        [Route("delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {

            var result = await _mpService.DeleteMPAsync(id);
            if (result.IsSuccess == true)
            {
                return Ok("Mp Deleted succesfully");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }
    }
}
