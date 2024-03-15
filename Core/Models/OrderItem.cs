namespace Core.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public int FoodId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Food Food { get; set; }
    }
}
