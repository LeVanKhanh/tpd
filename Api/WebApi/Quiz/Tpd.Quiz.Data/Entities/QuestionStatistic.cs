using Tpd.Core.Data;

namespace Tpd.Quiz.Data.Entities
{
    public class QuestionStatistic : EntityCore
    {
        public Question Question { get; set; }
        public int TotalLoad { get; set; }
        public int TotalAnswer { get; set; }
        public int TotalCorrect { get; set; }
    }
}
