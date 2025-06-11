using MediatR;
using WebApplicationTest1.dto;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.CQRS.Commands
{
    public class GetAllEmployeesHandler(IEmployeeRepository repository) : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeDto>>
    {

        private readonly IEmployeeRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        public Task<IEnumerable<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = _repository.GetAllAsync().Result;
            return Task.FromResult(employees.Select(e => new EmployeeDto
            {
                Name = e.Name,
                Age = e.Age,
                DepartmentId = e.DepartmentId
            }));
        }
    }
}
