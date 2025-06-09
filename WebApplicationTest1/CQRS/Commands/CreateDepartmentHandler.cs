using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class CreateDepartmentHandler(IDepartmentRepository repository) : IRequestHandler<CreateDepartmentCommand, DepartmentDto>
    {
        private readonly IDepartmentRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        public async Task<DepartmentDto> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department
            {
                Name = request.Name,
                Employees = []
            };

            var savedDepartment = await _repository.AddAsync(department);
            return savedDepartment == null
                ? throw new InvalidOperationException("Failed to create the department.")
                : new DepartmentDto
            {
                Id = savedDepartment.Id,
                Name = savedDepartment.Name
            };
        }
    }
}
