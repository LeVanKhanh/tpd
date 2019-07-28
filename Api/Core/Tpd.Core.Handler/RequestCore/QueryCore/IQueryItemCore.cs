using System;

namespace Tpd.Core.Handler.RequestCore.QueryCore
{
    public interface IQueryItemCore<TResponse> : IQuerySingleCore<TResponse>
    {
        Guid Id { get; set; }
    }
}
