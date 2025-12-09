using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Persistence.Configurations
{
    public class ShipperConfiguration : BaseConfiguration<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(100);
        }
    }

}
