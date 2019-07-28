using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class OptionConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.Property(p => p.Answer).HasMaxLength(1000);
        }
    }
}
