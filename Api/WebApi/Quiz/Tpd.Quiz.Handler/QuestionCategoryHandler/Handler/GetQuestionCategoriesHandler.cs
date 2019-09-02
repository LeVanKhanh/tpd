using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Request;

namespace Tpd.Quiz.Handler.QuestionCategoryHandler.Handler
{
    public class GetQuestionCategoriesHandler : QueryListHandlerBase<GetQuestionCategoriesQuery, QuestionCategoryModel>
    {
        private readonly IMapper _mapper;
        public GetQuestionCategoriesHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<QuestionCategoryModel>> BuildQueryAsync(GetQuestionCategoriesQuery query, RequestContextCore context)
        {
            var applicationQuery = Data.QuestionCategory.AsQueryable();
            if (!string.IsNullOrEmpty(query.Name))
            {
                applicationQuery.Where(w => w.Name.Contains(query.Name));
            }

            if (!string.IsNullOrEmpty(query.Desctiption))
            {
                applicationQuery.Where(w => w.Desctiption.Contains(query.Desctiption));
            }

            return applicationQuery.ProjectTo<QuestionCategoryModel>(_mapper.ConfigurationProvider);
        }
    }
}
