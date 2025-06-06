using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.dto;
using WebApplicationTest1.service;
using WebApplicationTest1.validator;

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

            //var  validator = new EmployeeValidator();
            //var validationResult = await validator.ValidateAsync(employeeDto);

            //if (!validationResult.IsValid)
            //{
            //    return BadRequest(validationResult.Errors.Select(e => e.ErrorMessage));
            //}
            if (employeeDto == null)
            {
                return BadRequest("Employee cannot be null");
            }
            try
            {
                var result = await _employeeService.CreateAsync(employeeDto);
                //return CreatedAtAction(nameof(result), new {id = result.Name}, result);
                return CreatedAtAction(nameof(AddEmployee), new { id = result.Name }, result);
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
