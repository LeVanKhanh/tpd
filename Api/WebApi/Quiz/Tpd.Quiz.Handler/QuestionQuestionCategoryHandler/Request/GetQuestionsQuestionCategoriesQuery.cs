using System;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;

namespace Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Request
{
    public class GetQuestionsQuestionCategoriesQuery : QueryListCore<QuestionQuestionCategoryListItemModel>
    {
        public Guid? QuestionId { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
