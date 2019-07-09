using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.QueryHandlerBase
{
    public abstract class QueryListHandlerBase<TQuery, TResponse> : QueryListHandlerCore<TQuery, TResponse>
        where TQuery : IQueryListCore<TResponse>
        where TResponse : new()
    {
        protected new DatabaseContext Data;
        public QueryListHandlerBase(DatabaseContext data)
            : base(data)
        {
            Data = data;
        }
    }
}
