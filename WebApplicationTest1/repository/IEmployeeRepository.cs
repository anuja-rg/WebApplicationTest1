using WebApplicationTest1.dto;
using WebApplicationTest1.models;

namespace WebApplicationTest1.repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeeByProjectAsync(int projectId);
        Task<IEnumerable<Employee>> GetEmployeesAbove20Async();
        Task<IEnumerable<Employee>> GetEmployeesByProjectAsync(int projectId);
        Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjectsAsync();
    }
}
