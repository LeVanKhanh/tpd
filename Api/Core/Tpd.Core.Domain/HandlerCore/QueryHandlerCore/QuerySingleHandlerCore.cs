using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore.QueryHandlerCore
{
    public abstract class QuerySingleHandlerCore<TQuery, TResponse> : QueryHandlerCore<TQuery, TResponse>
        where TQuery : IQuerySingleCore<TResponse>
        where TResponse : new()
    {
        public QuerySingleHandlerCore(DatabaseContextCore data, IValidationService validationService)
            : base(data, validationService)
        {

        }

        protected sealed async override Task<IResultCore<TResponse>> Handle(TQuery query, RequestContextCore context)
        {
            var result = new ResultCore<TResponse>
            {
                Success = true
            };

            var queryable = await BuildQuery(query, context);

            if (queryable == null)
            {
                result.Success = false;
                result.ErrorMessages = query.Messages;
                return result;
            }

            result.Result = await queryable.FirstOrDefaultAsync();

            return result;
        }

        protected abstract Task<IQueryable<TResponse>> BuildQuery(TQuery query, RequestContextCore context);
    }
}
