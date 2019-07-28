using System;
using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class QuestionQuestionCategory : EntityCore
    {
        public Guid QuestionId { get; set; }
        public Guid QuestionCategoryId { get; set; }
        public Question Question { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
    }
}
