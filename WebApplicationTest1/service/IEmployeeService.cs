using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.service
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> CreateAsync(EmployeeDto employeeDto);
        Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjects();
    }
}
