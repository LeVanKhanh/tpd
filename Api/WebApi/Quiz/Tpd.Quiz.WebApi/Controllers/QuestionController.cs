using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Quiz.Handler.QuestionHandler.Model;
using Tpd.Quiz.Handler.QuestionHandler.Request;

namespace Tpd.Quiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : CurdControllerCore<QuestionModel, QuestionModel, QuestionModel, QuestionModel, GetQuestionsQuery>
    {
        public QuestionController(IHandlerMediator<QuestionModel, QuestionModel, QuestionModel, QuestionModel, GetQuestionsQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
