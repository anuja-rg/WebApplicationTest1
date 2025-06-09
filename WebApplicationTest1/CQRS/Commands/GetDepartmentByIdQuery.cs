using MediatR;
using WebApplicationTest1.dto;

namespace WebApplicationTest1.CQRS.Commands
{
    public record GetDepartmentByIdQuery(int Id) : IRequest<DepartmentDto>
    {
    }
}
