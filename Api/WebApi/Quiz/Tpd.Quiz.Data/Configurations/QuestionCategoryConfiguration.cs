﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data.Configurations
{
    public class QuestionCategoryConfiguration : IEntityTypeConfiguration<QuestionCategory>
    {
        public void Configure(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Desctiption).HasMaxLength(1000);
        }
    }
}
