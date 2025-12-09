namespace OnionVb02.Domain.Entities
{
    public class Shipper : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        // İlişkiler
        public virtual ICollection<Order> Orders { get; set; }
    }
}
