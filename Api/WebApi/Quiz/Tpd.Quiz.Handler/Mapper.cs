using AutoMapper;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.OptionHandler.Model;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionHandler.Model;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;

namespace Tpd.Quiz.Handler
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<QuestionQuestionCategory, QuestionQuestionCategoryListItemModel>();
            CreateMap<QuestionQuestionCategory, QuestionQuestionCategoryModel>().ReverseMap();
            CreateMap<Option, OptionModel>().ReverseMap();
            CreateMap<QuestionCategory, QuestionCategoryModel>().ReverseMap();
            CreateMap<Question, QuestionModel>().ReverseMap();
        }
    }
}
