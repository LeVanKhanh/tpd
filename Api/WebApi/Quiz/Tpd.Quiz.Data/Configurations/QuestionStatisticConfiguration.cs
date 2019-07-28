using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionStatisticConfiguration : IEntityTypeConfiguration<QuestionStatistic>
    {
        public void Configure(EntityTypeBuilder<QuestionStatistic> builder)
        {
            builder.HasOne(o => o.Question).WithMany().HasForeignKey(f => f.Id);
        }
    }
}
