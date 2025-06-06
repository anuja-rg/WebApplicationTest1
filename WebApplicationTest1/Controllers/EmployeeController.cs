using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.dto;
using WebApplicationTest1.service;
using WebApplicationTest1.service.impl;

namespace WebApplicationTest1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, Employee!";
        }

        [HttpPost]
        public ActionResult<EmployeeDto> AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                return BadRequest("Employee cannot be null");
            }
            try
            {
                var result = _employeeService.CreateAsync(employeeDto).GetAwaiter().GetResult();
                return CreatedAtAction(nameof(Get), new { id = employeeDto.Id }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
