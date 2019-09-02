using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;
using Tpd.Quiz.Handler.QuestionHandler.Model;
using Tpd.Quiz.Handler.QuestionHandler.Request;

namespace Tpd.Quiz.Handler.QuestionHandler.Handler
{
    public class GetQuestionsHandler : QueryListHandlerBase<GetQuestionsQuery, QuestionModel>
    {
        private readonly IMapper _mapper;
        public GetQuestionsHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<QuestionModel>> BuildQueryAsync(GetQuestionsQuery query, RequestContextCore context)
        {
            var applicationQuery = Data.Question.AsQueryable();
            if (!string.IsNullOrEmpty(query.TheQuestion))
            {
                applicationQuery.Where(w => w.TheQuestion.Contains(query.TheQuestion));
            }

            return applicationQuery.ProjectTo<QuestionModel>(_mapper.ConfigurationProvider);
        }
    }
}
