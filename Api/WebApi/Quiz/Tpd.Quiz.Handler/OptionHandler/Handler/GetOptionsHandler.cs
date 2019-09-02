using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Quiz.Data;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;
using Tpd.Quiz.Handler.OptionHandler.Model;
using Tpd.Quiz.Handler.OptionHandler.Request;

namespace Tpd.Quiz.Handler.OptionHandler.Handler
{
    public class GetOptionsHandler : QueryListHandlerBase<GetOptionsQuery, OptionModel>
    {
        private readonly IMapper _mapper;
        public GetOptionsHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<OptionModel>> BuildQueryAsync(GetOptionsQuery query, RequestContextCore context)
        {
            var applicationQuery = Data.Option.AsQueryable();
            if (!string.IsNullOrEmpty(query.Answer))
            {
                applicationQuery.Where(w => w.Answer.Contains(query.Answer));
            }

            return applicationQuery.ProjectTo<OptionModel>(_mapper.ConfigurationProvider);
        }
    }
}
