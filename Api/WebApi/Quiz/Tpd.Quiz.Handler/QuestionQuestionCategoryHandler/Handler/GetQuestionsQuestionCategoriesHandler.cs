using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Request;

namespace Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Handler
{
    public  class GetQuestionsQuestionCategoriesHandler : QueryListHandlerBase<GetQuestionsQuestionCategoriesQuery, QuestionQuestionCategoryListItemModel>
    {
        private readonly IMapper _mapper;
        public GetQuestionsQuestionCategoriesHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<QuestionQuestionCategoryListItemModel>> BuildQueryAsync(GetQuestionsQuestionCategoriesQuery query, RequestContextCore context)
        {
            var questionQuestionCategoryQuery = Data.QuestionQuestionCategory.AsQueryable();

            if (query.QuestionId.HasValue)
            {
                questionQuestionCategoryQuery = questionQuestionCategoryQuery.Where(w => w.QuestionId == query.QuestionId);
            }

            if (query.CategoryId.HasValue)
            {
                questionQuestionCategoryQuery = questionQuestionCategoryQuery.Where(w => w.QuestionCategoryId == query.CategoryId);
            }

            return questionQuestionCategoryQuery.ProjectTo<QuestionQuestionCategoryListItemModel>(_mapper.ConfigurationProvider);
        }
    }
}
