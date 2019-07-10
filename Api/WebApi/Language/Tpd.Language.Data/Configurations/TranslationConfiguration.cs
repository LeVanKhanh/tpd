using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data.Configurations
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.HasOne(o => o.ResourceDefault).WithMany().HasForeignKey(f => f.ResourceDefaultId);
            builder.HasOne(o => o.Culture).WithMany().HasForeignKey(f => f.CultureId);
        }
    }
}
