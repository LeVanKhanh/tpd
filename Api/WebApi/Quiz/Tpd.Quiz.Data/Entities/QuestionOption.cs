using System;
using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class QuestionOption : EntityCore
    {
        public Guid QuestionId { get; set; }
        public Guid OptionId { get; set; }
        public Question Question { get; set; }
        public Option Option { get; set; }
        public bool IsKey { get; set; }
        public string Explanation { get; set; }
    }
}
