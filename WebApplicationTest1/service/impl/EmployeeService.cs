using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.service.impl
{
    public class EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository) : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        private readonly IDepartmentRepository _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));

        public async Task<IEnumerable<EmployeeDto>> CreateAsync(EmployeeDto employeeDto)
        {
            var existingDepartment = await _departmentRepository.GetByIdAsync(employeeDto.DepartmentId) ?? throw new ArgumentException($"Department with ID {employeeDto.DepartmentId} does not exist.");
            Employee employee = new()
            {
                Id = employeeDto.Id,
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                DepartmentId = employeeDto.DepartmentId,
                DepartmentInfo = existingDepartment,
                EmployeeProjects = []
            };

            var addedEmployee = await _employeeRepository.AddAsync(employee);
            return (IEnumerable<EmployeeDto>)(addedEmployee ?? throw new InvalidOperationException("Failed to add the employee."));
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjects()
        {
            return (IEnumerable<EmployeeProjectDto>)await _employeeRepository.GetEmployeesWithProjectsAsync();
        }

        public Task<Employee?> UpdateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<dto.EmployeeProjectDto>> IEmployeeService.GetEmployeesWithProjects()
        {
            throw new NotImplementedException();
        }
    }
}
