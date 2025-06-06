using WebApplicationTest1.dto;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.service.impl
{
    public class ProjectService(IProjectRepository projectRepository) : IProjectService
    {

        private readonly IProjectRepository _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));

        public Task<ProjectDto> CreateProjectAsync(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectDto?> GetProjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectDto> UpdateProjectAsync(ProjectDto project)
        {
            throw new NotImplementedException();
        }


    }
}
