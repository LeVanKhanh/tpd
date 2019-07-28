using System;
using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class Question : EntityCore
    {
        public string TheQuestion { get; set; }
        public Guid? ImageId { get; set; }
        public string Explanation { get; set; }
    }
}
