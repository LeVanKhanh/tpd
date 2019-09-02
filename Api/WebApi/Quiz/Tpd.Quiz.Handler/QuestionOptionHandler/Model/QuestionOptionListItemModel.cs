using System;

namespace Tpd.Quiz.Handler.QuestionOptionHandler.Model
{
    public class QuestionOptionListItemModel
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string TheQuestion { get; set; }
        public Guid OptionId { get; set; }
        public string TheOptionAswer { get; set; }
        public bool IsKey { get; set; }
        public string Explanation { get; set; }
    }
}
