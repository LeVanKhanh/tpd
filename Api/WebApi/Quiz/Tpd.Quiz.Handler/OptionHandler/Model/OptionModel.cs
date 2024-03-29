﻿using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Quiz.Handler.OptionHandler.Model
{
    public class OptionModel : IEntityModel
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Answer { get; set; }
        public Guid? ImageId { get; set; }
        public bool IsKey { get; set; }
        public string Explanation { get; set; }
    }
}
