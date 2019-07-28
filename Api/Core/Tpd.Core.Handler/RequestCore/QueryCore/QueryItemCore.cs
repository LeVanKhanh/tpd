using System;

namespace Tpd.Core.Handler.RequestCore.QueryCore
{
    public class QueryItemCore<TResponse> : QuerySingleCore<TResponse>, IQueryItemCore<TResponse>
    {
        public Guid Id { get; set; }
    }
}
