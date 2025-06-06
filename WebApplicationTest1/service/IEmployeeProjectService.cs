using WebApplicationTest1.dto;

namespace WebApplicationTest1.service
{
    public interface IEmployeeProjectService
    {
        Task<List<EmployeeProjectDto>> GetEmployeeProjectsAsync(int employeeId);
        Task<EmployeeProjectDto> GetEmployeeProjectAsync(int employeeId, int projectId);
        Task AddEmployeeProjectAsync(EmployeeProjectDto employeeProject);
        Task UpdateEmployeeProjectAsync(EmployeeProjectDto employeeProject);
        Task DeleteEmployeeProjectAsync(int employeeId, int projectId);
    }
}
