using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.MS;
using Application.DTOs.Service;
using Domain.Concrets;
using Domain.Entities;
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
        public IActionResult GetMPs(int? page, int? pageSize)
        {
            var result = _mpService.GetMPsAsync(page, pageSize).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);
            
        }

        [HttpGet("List")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMpsToList(int? page, int? pageSize)
        {
            var result = _mpService.GetMPsToListAsync(page, pageSize).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMpServices(int? page, int? pageSize, int? id)
        {

            var result = _mpService.FindServicesByMPidAsync(page,pageSize,id).Result;
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.ErrorMessage);
          
        }


        [HttpPost("NewMP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateMP(MaintenancePlanCreateDto maintenancePlanCreateDto)
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



        [HttpGet("MetricType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPlanMetricType()
        {
            var metricType = Enum.GetNames(typeof(Metrictype)).ToList();
            return Ok(metricType);
        }

        [Route("StatusChange")]
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ChangeStatus(int id, MaintenencePlanStatus newStatus)
        {
            _mpService.ChangeMpStatusAsync(id, newStatus);

            return StatusCode(200, "Status Updated");
        }

        [HttpPost("SetMpSetting")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SetMpSettings([FromForm]MsSetDto msSetDto)
        {
            var result = await _mpService.SetMpSettings(msSetDto);

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }

        [HttpPost("MpCompleted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> IsMpCompleted(MpCompleted mpCompleted)
        {
            var result = await _mpService.IsMpCompleted(mpCompleted);

            if (result.IsSuccess)
            {
                return Ok(result.Data);
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
        public IActionResult GetMpsforInput(string? name)
        {
            var result = _mpService.GetMpsForInput(name).Result;

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
           
            return BadRequest(result.ErrorMessage) ;

        }

        [HttpGet("EquipmentMpsDropDown")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentMpsforInput(int id)
        {
            var result = _mpService.GetEquipmentMps(id).Result;

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);

        }


    }
}
