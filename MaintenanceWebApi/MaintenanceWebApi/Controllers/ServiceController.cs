using Application.Abstraction.Services;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServeServices _servService;


        public ServiceController(IServeServices servService)
        {
            _servService = servService;
        }


        [Route("ModMP")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(ServiceUpdateDto serviceUpdateDto)
        {
            await _servService.UpdateServiceAsync(serviceUpdateDto);
            return StatusCode(200, "Service Updated");
        }


        [Route("delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {

            var result = await _servService.DeleteServiceAsync(id);
            if (result.IsSuccess == true)
            {
                return Ok("Service Deleted succesfully");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }

        [HttpPost("NewMP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateService(ServiceCreateDto serviceCreateDto)
        {
            var result = await _servService.CreateServiceAsync(serviceCreateDto);

            if (result.IsSuccess)
            {
                return Ok("Service created successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetService(int? id)
        {
            var Service = _servService.FindServiceAsync( id);
            return Ok(Service);
        }


    }
}
