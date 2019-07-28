using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionOptionConfiguration : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> builder)
        {
            builder.Property(p => p.Explanation).HasMaxLength(2000);
            builder.HasOne(o => o.Question).WithMany().HasForeignKey(f => f.QuestionId);
            builder.HasOne(o => o.Option).WithMany().HasForeignKey(f => f.OptionId);
        }
    }
}
