using Application.Abstraction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetDepartments(int page, int pageSize)
        {
            var Mps = _mpService.GetMPsAsync(page, pageSize);
            return Ok(Mps);
        }

    }
}
