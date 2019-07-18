using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Example.Data.Read.Entities;

namespace Tpd.Example.Data.Read.Configurations
{
    public class MasterDataCategoryConfiguration : IEntityTypeConfiguration<MasterDataCategory>
    {
        public void Configure(EntityTypeBuilder<MasterDataCategory> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).HasMaxLength(1000);
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
