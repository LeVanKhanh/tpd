using AutoMapper;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;

namespace Tpd.Quiz.Handler
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<QuestionQuestionCategory, QuestionQuestionCategoryListItemModel>();
        }
    }
}
