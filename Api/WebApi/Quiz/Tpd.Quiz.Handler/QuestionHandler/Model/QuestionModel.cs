using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Quiz.Handler.QuestionHandler.Model
{
    public class QuestionModel : IEntityModel
    {
        public Guid Id { get; set; }
        public string TheQuestion { get; set; }
        public Guid? ImageId { get; set; }
        public string Explanation { get; set; }
    }
}
