using Domain.Concrets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstantsController : ControllerBase
    {
        [HttpGet("EquipmentStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEquipmentStatuses()
        {
            var equipmentStatus = Enum.GetNames(typeof(EquipmentStatus)).ToList();
            return Ok(equipmentStatus);
        }

        [HttpGet("MPStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMpStatuses()
        {
            var mpStatus = Enum.GetNames(typeof(MaintenencePlanStatus)).ToList();
            return Ok(mpStatus);
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

        [HttpGet("MetricType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPlanMetricTypes()
        {
            var metricType = Enum.GetNames(typeof(Metrictype)).ToList();
            return Ok(metricType);
        }


        [HttpGet("ServiceType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetServiceTypes()
        {
            var serviceType = Enum.GetNames(typeof(ServiceType)).ToList();
            return Ok(serviceType);
        }


        [HttpGet("Operationtype")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOperationTypes()
        {
            var operations = Enum.GetNames(typeof(Operation)).ToList();
            return Ok(operations);
        }

    }
}
