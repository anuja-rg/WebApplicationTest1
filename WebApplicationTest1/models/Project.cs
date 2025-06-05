namespace WebApplicationTest1.models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
