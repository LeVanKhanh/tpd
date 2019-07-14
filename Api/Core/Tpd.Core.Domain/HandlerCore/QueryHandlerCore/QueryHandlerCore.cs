using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.RequestCore;

namespace Tpd.Core.Domain.HandlerCore.QueryHandlerCore
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
