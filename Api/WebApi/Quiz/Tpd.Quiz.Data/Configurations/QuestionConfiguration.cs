using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(p => p.TheQuestion).HasMaxLength(1000);
            builder.Property(p => p.Explanation).HasMaxLength(2000);
        }
    }
}
