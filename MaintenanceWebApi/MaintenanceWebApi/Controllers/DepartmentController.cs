using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;
using Persistence.Services.Common;

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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetDepartments(int page, int pageSize)
        {
            //var departments = _departmentService.GetDepartmentsAsync(page, pageSize);


            var serviceResult = _departmentService.GetDepartmentsAsync(page, pageSize).Result;

            if (!serviceResult.IsSuccess)
            {
                if (serviceResult.ErrorMessage == "Params is not okay")
                    return BadRequest();
                else if (serviceResult.ErrorMessage == "There is no Equipment in DB")
                    return NotFound();
            }

            return Ok(serviceResult.Data);

            //return Ok(departments);
        }

        [HttpPost("NewDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateDepartment(DepartmentCreateDto equipmentCreateDto)
        {
            var result = await _departmentService.CreateDepartmentAsync(equipmentCreateDto);

            if (result.IsSuccess)
            {
                return Ok("Department created successfully.");
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
           
        }

        [Route("delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        [Route("ModDepartment")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(DepartmentUpdateDto departmentUpdateDto)
        {
           _departmentService.UpdateDepartmentAsync(departmentUpdateDto);
           
            return StatusCode(200, "Department Updated");
        }

    }
}
