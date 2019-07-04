using System;

namespace Tpd.Core.Domain.RequestCore.QueryCore
{
    public interface IQueryByIdCore<TResponse> : IQuerySingleCore<TResponse>
    {
        Guid Id { get; set; }
    }
}
