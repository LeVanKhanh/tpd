using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tpd.Core.Data
{
    public abstract class EntityTypeConfigurationCore<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntityCore
    {
        public abstract void ConfigureCore(EntityTypeBuilder<TEntity> builder);

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            ConfigureCore(builder);
            builder.HasQueryFilter(o => !o.IsDeleted);
        }
    }
}
