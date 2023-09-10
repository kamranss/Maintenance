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
        public IActionResult GetEquipmentStatuses(string? name)
        {

            if (name == null)
            {
                var equipmentStatus = Enum.GetNames(typeof(EquipmentStatus)).ToList();
                return Ok(equipmentStatus);
            }

            var equipmentStatuss = Enum.GetNames(typeof(EquipmentStatus))
                .Where(status => status.ToString().Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(equipmentStatuss);


        }

        [HttpGet("UsagehiistoryStatuses")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUsageHistoryStatuses()
        {
            var usageHistoryStatuses = Enum.GetNames(typeof(UsageHistoryStatus)).ToList();
            return Ok(usageHistoryStatuses);
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
        public IActionResult GetEquipmentLocation(string? name)
        {
            if (name == null)
            {
                var locationNames = Enum.GetNames(typeof(Location)).ToList();
                return Ok(locationNames);
            }

            var matchingLocations = Enum.GetNames(typeof(Location))
                .Where(location => location.ToString().Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(matchingLocations);

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


        [HttpGet("OperationType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOperationTypes(string? name)
        {

            if (name == null)
            {
                var matchingOperationNames = Enum.GetNames(typeof(Operation)).ToList();
                return Ok(matchingOperationNames);
            }

            var matchingOperation = Enum.GetNames(typeof(Operation))
                .Where(operation => operation.ToString().Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(matchingOperation);


            //var operations = Enum.GetNames(typeof(Operation)).ToList();
            //return Ok(operations);
        }

    }
}
