using Application.Abstraction.Services;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Domain.Entities;
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


        [Route("ModService")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(ServiceUpdateDto serviceUpdateDto)
        {
            var result = await _servService.UpdateServiceAsync(serviceUpdateDto);
            if (result.IsSuccess)
            {
                StatusCode(200, "Service Updated");
            }
            return  BadRequest(result.ErrorMessage);
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

        [HttpPost("NewService")]
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
            var result = _servService.FindServiceAsync( id).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpPost("ServiceCompleted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> IsServiceCompleted(ServiceHistoryDto serviceHistoryDto)
        {
            var result = await _servService.IsServiceCompleted(serviceHistoryDto);

            if (result.IsSuccess)
            {
                return Ok("Service completed successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }


    }
}
