using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.RequestCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.QueryHandlerBase
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
