using System;

namespace Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model
{
    public class QuestionQuestionCategoryListItemModel
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid QuestionCategoryId { get; set; }
    }
}
