﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Core.Data;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionConfiguration : EntityTypeConfigurationCore<Question>
    {
        public override void ConfigureCore(EntityTypeBuilder<Question> builder)
        {
            builder.Property(p => p.TheQuestion).HasMaxLength(1000);
            builder.Property(p => p.Explanation).HasMaxLength(2000);
        }
    }
}
