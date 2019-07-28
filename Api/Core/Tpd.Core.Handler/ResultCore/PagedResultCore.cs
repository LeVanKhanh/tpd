using System.Collections.Generic;

namespace Tpd.Core.Handler.ResultCore
{
    public class PagedResultCore<T> : ResultCore<List<T>>, IPagedResultCore<T>
    {
        public int TotalRow { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
