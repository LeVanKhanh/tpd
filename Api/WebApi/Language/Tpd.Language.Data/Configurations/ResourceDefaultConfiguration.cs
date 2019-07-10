using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data.Configurations
{
    public class ResourceDefaultConfiguration : IEntityTypeConfiguration<ResourceDefault>
    {
        public void Configure(EntityTypeBuilder<ResourceDefault> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(500);
        }
    }
}
