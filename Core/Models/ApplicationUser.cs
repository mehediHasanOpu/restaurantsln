namespace Core.Models
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
