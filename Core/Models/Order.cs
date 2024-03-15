using Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int TableId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string OrderNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public Table Table { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderPackage> OrderPackages { get; set; }
    }
}
