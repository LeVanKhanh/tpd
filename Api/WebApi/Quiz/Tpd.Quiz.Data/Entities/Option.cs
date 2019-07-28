using System;
using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class Option : EntityCore
    {
        public string Answer { get; set; }
        public Guid? ImageId { get; set; }
    }
}
