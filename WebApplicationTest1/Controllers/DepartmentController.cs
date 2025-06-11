using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.CQRS.Commands;

namespace WebApplicationTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentCommand command)
        {
            var createdDepartment = await _mediator.Send(command);
            return CreatedAtAction(nameof(CreateDepartment), new { id = createdDepartment.Id }, createdDepartment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var query = new GetAllDepartmentsQuery();
            var departments = await _mediator.Send(query);
            return Ok(departments);
        }
    }
}
