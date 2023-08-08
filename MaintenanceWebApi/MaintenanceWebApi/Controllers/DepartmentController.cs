using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
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
        public IActionResult GetDepartments(int page, int pageSize)
        {
            var departments = _departmentService.GetDepartmentsAsync(page, pageSize);
            return Ok(departments);
        }

        [HttpPost("NewDepartment")]
        public async Task<IActionResult> CreateDepartment(DepartmentCreateDto equipmentCreateDto)
        {
            var result = await _departmentService.CreateDepartmentAsync(equipmentCreateDto);

            if (result.IsSuccess)
            {
                return Ok("Equipment created successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
           
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
           
            var result = await _departmentService.DeleteDepartmentAsync(id);
            if (result.IsSuccess == true)
            {
                return Ok("Department Deleted succesfully");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
        }


    }
}
