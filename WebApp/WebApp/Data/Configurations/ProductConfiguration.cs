using JwtExample.Data.Configurations.Common;
using JwtExample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtExample.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.BaseAuditableConfigure();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Price).HasDefaultValue(0).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(x => x.Count).HasDefaultValue(0);
    }
}