using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.CQRS.Commands;
using WebApplicationTest1.dto;
using WebApplicationTest1.service;

namespace WebApplicationTest1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        //private readonly IEmployeeService _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, Employee!";
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] CreateEmployeeCommand command)
        {
           
            var createdEmployee = await _mediator.Send(command);
            return CreatedAtAction(nameof(AddEmployee), new { id = createdEmployee.Name }, createdEmployee);
        }
    }
}
