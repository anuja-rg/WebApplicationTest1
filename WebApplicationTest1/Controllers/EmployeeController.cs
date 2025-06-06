using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.dto;
using WebApplicationTest1.service;

namespace WebApplicationTest1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(IEmployeeService employeeService) : ControllerBase
    {
        private readonly IEmployeeService _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, Employee!";
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                return BadRequest("Employee cannot be null");
            }
            try
            {
                var result = await _employeeService.CreateAsync(employeeDto);
                return Ok(result);
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
