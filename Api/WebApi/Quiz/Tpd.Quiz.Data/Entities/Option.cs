using System;
using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class Option : EntityCore
    {
        public Guid QuestionId { get; set; }
        public string Answer { get; set; }
        public Guid? ImageId { get; set; }
        public bool IsKey { get; set; }
        public string Explanation { get; set; }
        public Question Question { get; set; }
    }
}
