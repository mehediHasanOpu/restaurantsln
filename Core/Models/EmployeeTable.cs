namespace Core.Models
{
    public class EmployeeTable
    {
        public int Id { get; set; }

        public Guid EmployeeId { get; set; }
        public int TableId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Table Table { get; set; }
    }
}
