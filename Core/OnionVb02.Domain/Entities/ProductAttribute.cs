namespace OnionVb02.Domain.Entities
{
    public class ProductAttribute : BaseEntity
    {
        public string Name { get; set; } // Örn: "Renk", "Beden", "RAM"
        public virtual ICollection<ProductAttributeValue> AttributeValues { get; set; }
    }
}
