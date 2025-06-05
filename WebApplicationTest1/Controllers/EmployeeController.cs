using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.models;
using WebApplicationTest1.service;
using WebApplicationTest1.service.impl;

namespace WebApplicationTest1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(EmployeeService employeeService) : ControllerBase
    {

        private readonly IEmployeeService _employeeService = employeeService;

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, Employee!";
        }

        //[HttpPost]
        //public ActionResult<Employee> Post([FromBody] Employee employee)
        //{
        //    if (employee == null)
        //    {
        //        return BadRequest("Employee cannot be null");
        //    }
        //    // Here you would typically save the employee to a database
        //    // For now, we just return the employee back

        //    res = _employeeService.AddEmployee(employee).GetAwaiter().GetResult();

        //    return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        //}

    }
}
