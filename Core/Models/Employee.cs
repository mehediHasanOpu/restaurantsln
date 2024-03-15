using Core.Enums;

namespace Core.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Salary { get; set; }
        public Designation Designation { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }
    }
}
