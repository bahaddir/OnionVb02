using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Persistence.Configurations
{
    public class ProductAttributeValueConfiguration : BaseConfiguration<ProductAttributeValue>
    {
        public override void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            base.Configure(builder);
            // aynı urunun ayni ozelliginden bir tane olabilir
            builder.HasIndex(x => new { x.ProductId, x.ProductAttributeId }).IsUnique();
        }

    }

}
