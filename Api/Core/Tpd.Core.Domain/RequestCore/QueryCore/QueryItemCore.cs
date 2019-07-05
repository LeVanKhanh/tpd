using System;

namespace Tpd.Core.Domain.RequestCore.QueryCore
{
    public class QueryItemCore<TResponse> : QuerySingleCore<TResponse>, IQueryItemCore<TResponse>
    {
        public Guid Id { get; set; }
    }
}
