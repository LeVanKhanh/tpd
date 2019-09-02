using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;
using Tpd.Quiz.Handler.QuestionOptionHandler.Model;
using Tpd.Quiz.Handler.QuestionOptionHandler.Request;

namespace Tpd.Quiz.Handler.QuestionOptionHandler.Handler
{
    public class GetQuestionOptionsHandler : QueryListHandlerBase<GetQuestionOptionsQuery, QuestionOptionListItemModel>
    {
        private readonly IMapper _mapper;
        public GetQuestionOptionsHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<QuestionOptionListItemModel>> BuildQueryAsync(GetQuestionOptionsQuery query, RequestContextCore context)
        {
            var applicationQuery = Data.QuestionOption.AsQueryable();

            if (query.QuestionId.HasValue)
            {
                applicationQuery = applicationQuery.Where(w => w.QuestionId == query.QuestionId);
            }

            if (!string.IsNullOrEmpty(query.TheQuestion))
            {
                applicationQuery = applicationQuery.Where(w => w.Question.TheQuestion.Contains(query.TheQuestion));
            }

            if (query.OptionId.HasValue)
            {
                applicationQuery = applicationQuery.Where(w => w.OptionId == query.OptionId);
            }

            if (!string.IsNullOrEmpty(query.TheOptionAswer))
            {
                applicationQuery = applicationQuery.Where(w => w.Option.Answer.Contains(query.TheOptionAswer));
            }

            if (query.IsKey.HasValue)
            {
                applicationQuery = applicationQuery.Where(w => w.IsKey == query.IsKey);
            }

            return applicationQuery.Select(s => new QuestionOptionListItemModel
            {
                Explanation = s.Explanation,
                Id = s.Id,
                IsKey = s.IsKey,
                OptionId = s.OptionId,
                QuestionId = s.QuestionId,
                TheOptionAswer = s.Option.Answer,
                TheQuestion = s.Question.TheQuestion
            });
        }
    }
}
