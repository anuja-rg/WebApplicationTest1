using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, DepartmentDto>
    {
        private readonly IDepartmentRepository _repository;

        public CreateDepartmentHandler(IDepartmentRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<DepartmentDto> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department
            {
                Name = request.Name,
                Employees = []
            };

            var savedDepartment = await _repository.AddAsync(department);
            if (savedDepartment == null)
            {
                throw new InvalidOperationException("Failed to create the department.");
            }
            return new DepartmentDto
            {
                Id = savedDepartment.Id,
                Name = savedDepartment.Name
            };
        }
    }
}
