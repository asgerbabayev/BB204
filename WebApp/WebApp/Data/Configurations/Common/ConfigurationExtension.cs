using JwtExample.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtExample.Data.Configurations.Common;

public static class ConfigurationExtension
{
    public static EntityTypeBuilder<TEntity> BaseEntityConfigure<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : BaseEntity
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        return builder;
    }

    public static EntityTypeBuilder<TEntity> BaseAuditableConfigure<TEntity>(this EntityTypeBuilder<TEntity> builder)
       where TEntity : BaseAuditableEntity
    {
        BaseEntityConfigure(builder);
        builder.Property(x => x.Created).HasDefaultValueSql("GETUTCDATE()");
        return builder;
    }
}