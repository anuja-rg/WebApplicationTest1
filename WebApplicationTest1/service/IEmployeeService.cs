using WebApplicationTest1.dto;
using WebApplicationTest1.models;

namespace WebApplicationTest1.service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> CreateAsync(EmployeeDto employeeDto);
        Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjects();
    }
}
