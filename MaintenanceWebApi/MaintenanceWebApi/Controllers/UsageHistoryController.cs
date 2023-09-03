using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.UsageHistory;
using Domain.Concrets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsageHistoryController : ControllerBase
    {
        private readonly IUsageHistoryService _usageHistoryService;

        public UsageHistoryController(IUsageHistoryService usageHistoryService)
        {
            this._usageHistoryService = usageHistoryService;
        }


        [HttpPost("StartUsageHistory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateUsageHistory([FromForm]UsageHistoryCreateDto usageHistoryCreateDto)
        {
            var result = await _usageHistoryService.CreateUsageHistoryAsync(usageHistoryCreateDto);

            if (result.IsSuccess)
            {
                return Ok("History created successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }

        [Route("EndUsageStory")]
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> End(UsageHistoryEndDto usageHistoryEndDto)
        {
           var result = await _usageHistoryService.EndUsageHistoryAsync(usageHistoryEndDto);

            if (result.IsSuccess)
            {
                return StatusCode(200, "Status Updated");
            }

            return BadRequest(result.ErrorMessage);
        }



        [HttpGet("ByEquipmentId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEquipmentUsageHistory(int? equipmentId, int? page, int? pageSize)
        {

            var serviceResult = _usageHistoryService.FindEquipmentUsageHistoryAsync(equipmentId, page, pageSize).Result;

            if (!serviceResult.IsSuccess)
            {
               
                return  BadRequest(serviceResult.ErrorMessage);
            }

            return Ok(serviceResult.Data);

        }



        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UsageHistories( int? page, int? pageSize)
        {

            var serviceResult = _usageHistoryService.UsageHistoriesAsync( page, pageSize).Result;

            if (!serviceResult.IsSuccess)
            {

                return BadRequest(serviceResult.ErrorMessage);
            }

            return Ok(serviceResult.Data);

        }

    }
}
