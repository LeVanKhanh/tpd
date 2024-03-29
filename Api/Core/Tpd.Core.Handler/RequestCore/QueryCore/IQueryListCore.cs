﻿using Tpd.Core.Handler.ResultCore;

namespace Tpd.Core.Handler.RequestCore.QueryCore
{
    public interface IQueryListCore<TResponse> : IQueryCore<PagedResultCore<TResponse>>
    {
        bool IsPaged { get; set; }
        string OrderBy { get; set; }
        string OrderByDirection { get; set; }
        string ThenOrderBy { get; set; }
        string ThenOrderByDirection { get; set; }
        int Skip { get; set; }
        int Take { get; set; }
    }
}
