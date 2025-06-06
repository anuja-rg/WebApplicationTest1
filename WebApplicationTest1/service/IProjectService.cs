
using WebApplicationTest1.dto;

namespace WebApplicationTest1.service
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> GetAllProjectsAsync();
        Task<ProjectDto?> GetProjectByIdAsync(int id);
        Task<ProjectDto> CreateProjectAsync(ProjectDto project);
        Task<ProjectDto> UpdateProjectAsync(ProjectDto project);
        Task<bool> DeleteProjectAsync(int id);
    }
}
