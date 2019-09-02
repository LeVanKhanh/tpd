using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Handler.QuestionHandler.Model;

namespace Tpd.Quiz.Handler.QuestionHandler.Request
{
    public class GetQuestionsQuery : QueryListCore<QuestionModel>
    {
        public string TheQuestion { get; set; }
    }
}
