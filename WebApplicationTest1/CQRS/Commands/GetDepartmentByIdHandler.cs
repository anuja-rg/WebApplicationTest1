using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class GetDepartmentByIdHandler(IDepartmentRepository repository) : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        private readonly IDepartmentRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        public async Task<DepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request);
            var department = await _repository.GetByIdAsync(request.Id);
            return department == null
                ? throw new KeyNotFoundException($"Department with ID {request.Id} not found.")
                : new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name
            };
        }
    }
    {
    }
}
