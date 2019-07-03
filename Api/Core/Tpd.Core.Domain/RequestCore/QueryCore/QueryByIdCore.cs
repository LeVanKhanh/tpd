using System;

namespace Tpd.Core.Domain.RequestCore.QueryCore
{
    public class QueryByIdCore<TResponse> : QuerySingleCore<TResponse>, IQueryByIdCore<TResponse>
    {
        public Guid Id { get; set; }
    }
}
