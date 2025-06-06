using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.service.impl
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));

        public Task<IEnumerable<Employee>> CreateAsync(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<Employee>> CreateAsync(EmployeeDto employeeDto)
        //{
        //    if (employeeDto == null)
        //    {
        //        throw new ArgumentNullException(nameof(employeeDto), "Employee DTO cannot be null.");
        //    }

        //    Department department = 
        //    var employee = new Employee
        //    {
        //        Name = employeeDto.Name,
        //        Age = employeeDto.Age,
        //        DepartmentId = employeeDto.DepartmentId,
        //        //DepartmentInfo = employeeDto.Department,

        //    };
        //}

        public async Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjects()
        {
            return await _employeeRepository.GetEmployeesWithProjectsAsync();
        }
    }
}
