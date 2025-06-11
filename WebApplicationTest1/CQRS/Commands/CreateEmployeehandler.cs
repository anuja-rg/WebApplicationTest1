using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class CreateEmployeehandler(IEmployeeRepository repository, IDepartmentRepository departmentRepository) : IRequestHandler<CreateEmployeeCommand, EmployeeDto>
    {
        private readonly IEmployeeRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        private readonly IDepartmentRepository _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(repository));

        public async Task<EmployeeDto> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var employee = new Employee
            {
                Name = request.Name,
                Age = request.Age,
                DepartmentId = request.DepartmentId,
                EmployeeProjects = [],
            };

            var savedEmployee = await _repository.AddAsync(employee);

            return savedEmployee == null
                ? throw new InvalidOperationException("Failed to create employee.")
                : new EmployeeDto
            {
                Name = savedEmployee.Name,
                Age = savedEmployee.Age,
                DepartmentId = savedEmployee.DepartmentId
            };
        }
    }
}
