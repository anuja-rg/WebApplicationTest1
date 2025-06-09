using MediatR;
using WebApplicationTest1.dto;

namespace WebApplicationTest1.CQRS.Commands
{
    public record CreateEmployeeCommand(string Name, int Age, int DepartmentId) : IRequest<EmployeeDto>
    {
    }
}
