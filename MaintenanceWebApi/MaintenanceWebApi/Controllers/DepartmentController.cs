using Application.Abstraction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace MaintenanceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult GetDepartment(int? id)
        {
            //if (id == null)
            //{
            //    throw new ArgumentNullException("id");
            //}
           var department =  _departmentService.FindDepartmentAsync(id);
            return Ok(department);
        }

        [HttpGet("All")]
        public IActionResult GetEquipments(int pageSize, int pageNumber)
        {
            var departments = _departmentService.GetDepartmentsAsync(pageSize, pageNumber);
            return Ok(departments);
        }

    }
}
