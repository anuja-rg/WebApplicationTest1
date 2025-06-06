using WebApplicationTest1.dto;
using WebApplicationTest1.models;
using WebApplicationTest1.repository;

namespace WebApplicationTest1.service.impl
{
    public class DepartmentService(IDepartmentRepository departmentRepository) : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));

        public Task<DepartmentDto> CreateDepartmentAsync(DepartmentDto department)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            return await _departmentRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            var departments = await _departmentRepository.GetAllAsync();
            return [.. departments.Select(d => new DepartmentDto { Id = d.Id, Name = d.Name })];
        }

        public async Task<DepartmentDto?> GetDepartmentByIdAsync(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            if (department == null)
            {
                return null;
            }
            return new DepartmentDto
            { Id = department.Id, Name = department.Name };
        }

        public Task<DepartmentDto> UpdateDepartmentAsync(DepartmentDto department)
        {
            throw new NotImplementedException();
        }
    }
}
