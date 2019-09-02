using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Quiz.Handler.QuestionCategoryHandler.Model
{
    public class QuestionCategoryModel : IEntityModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desctiption { get; set; }
    }
}
