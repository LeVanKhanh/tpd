using System.Collections.Generic;

namespace Tpd.Core.Domain.ResultCore
{
    public interface IPagedResultCore<T> : IResultCore<List<T>>
    {
        int TotalRow { get; set; }
        int Skip { get; set; }
        int Take { get; set; }
    }
}
