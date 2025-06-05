using Microsoft.EntityFrameworkCore;
using WebApplicationTest1.dto;
using WebApplicationTest1.models;

namespace WebApplicationTest1.repository.repoImpl
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context) {}

        public async Task<IEnumerable<Employee>> GetEmployeeByProjectAsync(int projectId)
        {
            return await _context.EmployeeProjects
                .Where(ep => ep.ProjectId == projectId)
                .Select(ep => ep.Employee)
                .ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAbove20Async()
        {
            return await _context.Employees.Where(e => e.Age > 20).OrderByDescending(e => e.Age).ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByProjectAsync(int projectId)
        {
            return await _context.EmployeeProjects
                .Where(ep => ep.ProjectId == projectId)
                .Select(ep => ep.Employee)
                .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeProjectDto>> GetEmployeesWithProjectsAsync()
        {
            return await _context.Employees
                .Join(_context.EmployeeProjects,
                e => e.Id,
                ep => ep.EmployeeId,
                (e, ep) => new { EmployeeName = e.Name, ep.ProjectId })
                .Join(_context.Projects,
                ep => ep.ProjectId,
                p => p.Id,
                (ep, p) => new EmployeeProjectDto { EmployeeName = ep.EmployeeName, ProjectName = p.Name })
                .ToListAsync();
                
        }

        public async Task<IEnumerable<DepartmentEmployeeCountDto>> GetEmployeeCountByDepartmentAsync()
        {
            return await _context.Employees
                .GroupBy(e => e.DepartmentId)
                .Select(g => new DepartmentEmployeeCountDto
                { DepartmentId = g.Key, EmployeeCount = g.Count() })
                .ToListAsync();
        }
    }
}
