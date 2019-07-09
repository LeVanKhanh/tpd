using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.QueryHandlerBase
{
    public abstract class QueryListHandlerBase<TQuery, TResponse> : QueryHandlerCore<TQuery, PagedResultCore<TResponse>>
        where TQuery : IQueryListCore<TResponse>
        where TResponse : new()
    {
        public QueryListHandlerBase(DatabaseContext data)
            : base(data)
        {
        }
    }
}
