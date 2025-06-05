using WebApplicationTest1.dto;
using WebApplicationTest1.models;

namespace WebApplicationTest1.service
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
        Task<DepartmentDto?> GetDepartmentByIdAsync(int id);
        Task<DepartmentDto> CreateDepartmentAsync(DepartmentDto department);
        Task<DepartmentDto> UpdateDepartmentAsync(DepartmentDto department);
        Task<bool>DeleteDepartmentAsync(int id);
    }
}
