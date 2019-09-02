using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model
{
    public class QuestionQuestionCategoryModel : IEntityModel
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid QuestionCategoryId { get; set; }
    }
}
