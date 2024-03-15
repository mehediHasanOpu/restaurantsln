namespace Core.Models
{
    public class OrderPackage
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public int PackageId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Package Package { get; set; }

    }
}
