using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Model;

namespace Tpd.Quiz.Handler.QuestionCategoryHandler.Request
{
    public class GetQuestionCategoriesQuery:QueryListCore<QuestionCategoryModel>
    {
        public string Name { get; set; }
        public string Desctiption { get; set; }
    }
}
