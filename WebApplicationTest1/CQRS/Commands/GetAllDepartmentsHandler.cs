using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class GetAllDepartmentsHandler(IDepartmentRepository repository) : IRequestHandler<GetAllDepartmentsQuery, IEnumerable<DepartmentDto>>
    {
        private readonly IDepartmentRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        public Task<IEnumerable<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = _repository.GetAllAsync().Result;
            return Task.FromResult(departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name
            }));
        }
    }
}
