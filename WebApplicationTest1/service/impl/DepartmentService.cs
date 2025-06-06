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

        public Task<bool> DeleteDepartmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            throw new NotImplementedException();
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
