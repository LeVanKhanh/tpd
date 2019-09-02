using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Core.Data;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionQuestionCategoryConfiguration : EntityTypeConfigurationCore<QuestionQuestionCategory>
    {
        public override void ConfigureCore(EntityTypeBuilder<QuestionQuestionCategory> builder)
        {
            builder.HasOne(o => o.Question).WithMany().HasForeignKey(f => f.QuestionId);
            builder.HasOne(o => o.QuestionCategory).WithMany().HasForeignKey(f => f.QuestionCategoryId);
        }
    }
}
