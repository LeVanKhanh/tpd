using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public abstract class QueryListHandlerBase<TQuery, TResponse> : QueryListHandlerCore<TQuery, TResponse>
        where TQuery : IQueryListCore<TResponse>
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryListHandlerBase(DatabaseReadContext data)
            : base(data)
        {
            Data = data;
        }
    }
}
