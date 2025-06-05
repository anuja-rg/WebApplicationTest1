namespace WebApplicationTest1.models
{
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public required Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public required Project Project { get; set; }
    }
}
