using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Core.Handler.RequestCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase
{
    public abstract class QueryHandlerBase<TQuery, TResponse> : QueryHandlerCore<TQuery, TResponse>
        where TQuery : IRequestCore<TResponse>
        where TResponse : new()
    {
        public QueryHandlerBase(DatabaseContext data, IValidationService validationService)
           : base(data, validationService)
        {

        }
    }
}
