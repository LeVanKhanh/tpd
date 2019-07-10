using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data.Configurations
{
    public class ModuleResourceConfiguration : IEntityTypeConfiguration<ModuleResource>
    {
        public void Configure(EntityTypeBuilder<ModuleResource> builder)
        {
            builder.HasOne(o => o.Module).WithMany().HasForeignKey(f => f.ModuleId);
            builder.HasOne(o => o.Baseline).WithMany().HasForeignKey(f => f.ResourceDefaultId);
        }
    }
}
