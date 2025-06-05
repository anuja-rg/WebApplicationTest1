namespace WebApplicationTest1.models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Department { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public required Department DepartmentInfo { get; set; }

        public required List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
