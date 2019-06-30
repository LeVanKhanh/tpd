using System.Collections.Generic;

namespace Tpd.Core.Domain.ResultCore
{
    public interface IResultCore<T>
    {
        bool Success { get; set; }
        List<string> ErrorMessages { get; set; }
        T Result { get; set; }
    }
}
