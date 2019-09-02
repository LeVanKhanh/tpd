using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Request;

namespace Tpd.Quiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionQuestionCategoryController : CurdControllerCore<QuestionQuestionCategoryModel, QuestionQuestionCategoryModel,
         QuestionQuestionCategoryModel, QuestionQuestionCategoryListItemModel, GetQuestionsQuestionCategoriesQuery>
    {
        public QuestionQuestionCategoryController(IHandlerMediator<QuestionQuestionCategoryModel, QuestionQuestionCategoryModel,
         QuestionQuestionCategoryModel, QuestionQuestionCategoryListItemModel, GetQuestionsQuestionCategoriesQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
