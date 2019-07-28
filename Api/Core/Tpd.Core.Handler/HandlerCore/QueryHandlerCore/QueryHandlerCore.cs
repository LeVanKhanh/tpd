using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore;

namespace Tpd.Core.Handler.HandlerCore.QueryHandlerCore
{
    public abstract class QueryHandlerCore<TQuery, TResponse> : HandlerCore<TQuery, TResponse>
        where TQuery : IRequestCore<TResponse>
        where TResponse : new()
    {
        public QueryHandlerCore(DatabaseContextCore data, IValidationService validationService)
           : base(data, validationService)
        {
        }
    }
}
