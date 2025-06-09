using MediatR;
using WebApplicationTest1.dto;

namespace WebApplicationTest1.CQRS.Commands
{
    public record CreateDepartmentCommand(string Name) : IRequest<DepartmentDto>
    {
    }
}
