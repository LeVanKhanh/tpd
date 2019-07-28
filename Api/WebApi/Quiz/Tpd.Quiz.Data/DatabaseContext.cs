using Microsoft.EntityFrameworkCore;
using Tpd.Core.Data;
using Tpd.Quiz.Data.Entities;

namespace Tpd.Quiz.Data
{
    public class DatabaseContext : DatabaseContextCore
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
             : base(options)
        {

        }

        public DbSet<Question> Question { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<QuestionStatistic> QuestionStatistic { get; set; }
        public DbSet<QuestionCategory> QuestionCategory { get; set; }
        public DbSet<QuestionQuestionCategory> QuestionQuestionCategory { get; set; }
    }
}
