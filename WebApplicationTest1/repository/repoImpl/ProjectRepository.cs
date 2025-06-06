using WebApplicationTest1.models;

namespace WebApplicationTest1.repository.repoImpl
{
    public class ProjectRepository(AppDbContext context) : Repository<Project>(context), IProjectRepository
    {
    }
}
