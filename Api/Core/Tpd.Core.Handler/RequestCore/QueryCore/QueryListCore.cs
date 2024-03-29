﻿namespace Tpd.Core.Handler.RequestCore.QueryCore
{
    public class QueryListCore<TResponse> : QueryCore<TResponse>, IQueryListCore<TResponse>
    {
        public QueryListCore()
        {
            IsPaged = true;
            OrderByDirection = "acs";
            Skip = 0;
            Take = 10;
        }

        public bool IsPaged { get; set; }
        public string OrderBy { get; set; }
        public string OrderByDirection { get; set; }
        public string ThenOrderBy { get; set; }
        public string ThenOrderByDirection { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
