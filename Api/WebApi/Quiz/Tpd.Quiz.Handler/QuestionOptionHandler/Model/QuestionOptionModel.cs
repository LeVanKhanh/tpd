using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Quiz.Handler.QuestionOptionHandler.Model
{
    public class QuestionOptionModel:IEntityModel
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid OptionId { get; set; }
        public bool IsKey { get; set; }
        public string Explanation { get; set; }
    }
}
