using System;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Handler.QuestionOptionHandler.Model;

namespace Tpd.Quiz.Handler.QuestionOptionHandler.Request
{
    public class GetQuestionOptionsQuery:QueryListCore<QuestionOptionListItemModel>
    {
        public Guid? QuestionId { get; set; }
        public string TheQuestion { get; set; }
        public Guid? OptionId { get; set; }
        public string TheOptionAswer { get; set; }
        public bool? IsKey { get; set; }
    }
}
