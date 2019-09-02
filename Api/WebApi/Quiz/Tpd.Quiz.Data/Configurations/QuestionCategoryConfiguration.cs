using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Core.Data;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionCategoryConfiguration : EntityTypeConfigurationCore<QuestionCategory>
    {
        public override void ConfigureCore(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Desctiption).HasMaxLength(1000);
        }
    }
}
