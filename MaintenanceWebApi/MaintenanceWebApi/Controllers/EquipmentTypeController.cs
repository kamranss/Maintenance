using Application.Abstraction.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentTypeController : ControllerBase
    {
        private readonly IEquipmentTypeService _equipmentTypeService;

        public EquipmentTypeController(IEquipmentTypeService equipmentTypeService)
        {
            _equipmentTypeService = equipmentTypeService;
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEquipmentTypes(int? pageSize, int? pageNumber)
        {

            var result =  _equipmentTypeService.GetEquipmentTypesAsync(pageSize, pageNumber).Result;

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.ErrorMessage);
           
        }

        [HttpGet("DropDown")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetModelsforInput(string? name)
        {

            var result = _equipmentTypeService.GetTypesForInput(name).Result;
            return Ok(result.Data);

        }
    }
}
