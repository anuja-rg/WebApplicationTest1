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

        public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectDto?> GetProjectByIdAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if (project == null)
            {
                return null;
            }

            return new ProjectDto
            {
                Id = project.Id,
                Name = project.Name,
                //EmployeeProjects = project.EmployeeProjects.Select(ep => new EmployeeProjectDto
                //{
                //    EmployeeName = ep.Employee.Name,
                //    ProjectName = ep.Project.Name
                //}).ToList()
            };
        }

        public Task<ProjectDto> UpdateProjectAsync(ProjectDto project)
        {
            throw new NotImplementedException();
        }
    }
    public class EmployeeProjectDto
    {
        public required string EmployeeName { get; set; }
        public required string ProjectName { get; set; }
    }
}
