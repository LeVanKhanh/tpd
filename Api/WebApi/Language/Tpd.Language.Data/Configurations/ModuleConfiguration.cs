using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data.Configurations
{
    public class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.HasOne(o => o.Application).WithMany().HasForeignKey(f => f.ApplicationId);
        }
    }
}
