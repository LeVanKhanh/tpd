using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase
{
    public abstract class QuerySingleHandlerBase<TQuery, TResponse> : QueryHandlerCore<TQuery, TResponse>
        where TQuery : IQuerySingleCore<TResponse>
        where TResponse : new()
    {
        public QuerySingleHandlerBase(DatabaseContext data, IValidationService validationService)
            : base(data, validationService)
        {

        }
    }
}
