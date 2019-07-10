using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data.Configurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.Property(p => p.ShortName).HasMaxLength(50);
            builder.Property(p => p.FullName).HasMaxLength(200);
        }
    }
}
