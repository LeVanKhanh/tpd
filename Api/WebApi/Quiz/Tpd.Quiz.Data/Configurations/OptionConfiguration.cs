using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Core.Data;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class OptionConfiguration : EntityTypeConfigurationCore<Option>
    {
        public override void ConfigureCore(EntityTypeBuilder<Option> builder)
        {
            builder.HasOne(o => o.Question).WithMany().HasForeignKey(f => f.QuestionId);
            builder.Property(p => p.Explanation).HasMaxLength(2000);
            builder.Property(p => p.Answer).HasMaxLength(1000);
        }
    }
}
