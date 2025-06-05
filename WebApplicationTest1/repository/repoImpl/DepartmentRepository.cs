using WebApplicationTest1.models;

namespace WebApplicationTest1.repository.repoImpl
{
    public class DepartmentRepository(AppDbContext context) : Repository<Department>(context), IDepartmentRepository
    {
    }
}
