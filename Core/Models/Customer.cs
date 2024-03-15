namespace Core.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Address { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
