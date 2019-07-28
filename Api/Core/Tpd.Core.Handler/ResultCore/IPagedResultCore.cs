using System.Collections.Generic;

namespace Tpd.Core.Handler.ResultCore
{
    public interface IPagedResultCore<T> : IResultCore<List<T>>
    {
        int TotalRow { get; set; }
        int Skip { get; set; }
        int Take { get; set; }
    }
}
