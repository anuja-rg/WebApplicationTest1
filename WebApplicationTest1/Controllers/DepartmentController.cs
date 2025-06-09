using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.CQRS.Commands;
using WebApplicationTest1.dto;
using WebApplicationTest1.service;

namespace WebApplicationTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService departmentService, IMediator mediator) : ControllerBase
    {
        //private readonly IDepartmentService _departmentService;
        private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetDepartmentById(int id)
        //{
        //    var department = await _departmentService.GetDepartmentByIdAsync(id);
        //    if (department == null)
        //    {
        //        return NotFound($"Department with ID {id} not found.");
        //    }
        //    return Ok(department);
        //}

        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentCommand command)
        {
            var createdDepartment = await _mediator.Send(command);
            return CreatedAtAction(nameof(CreateDepartment), new { id = createdDepartment.Id }, createdDepartment);
        }
    }
}
