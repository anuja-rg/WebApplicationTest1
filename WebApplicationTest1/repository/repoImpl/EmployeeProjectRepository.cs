using WebApplicationTest1.models;

namespace WebApplicationTest1.repository.repoImpl
{
    public class EmployeeProjectRepository(AppDbContext context) : Repository<EmployeeProject>(context), IEmployeeProjectRepository
    {
    }
}
