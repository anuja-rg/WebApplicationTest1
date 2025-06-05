namespace WebApplicationTest1.models
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Employee> Employees { get; set; }
    }
}
