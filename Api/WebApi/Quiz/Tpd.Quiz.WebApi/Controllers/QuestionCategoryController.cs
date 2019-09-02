using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Request;

namespace Tpd.Quiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoryController : CurdControllerCore<QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, GetQuestionCategoriesQuery>
    {
        public QuestionCategoryController(IHandlerMediator<QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, GetQuestionCategoriesQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
