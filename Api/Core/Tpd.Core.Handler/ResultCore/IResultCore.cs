using System.Collections.Generic;

namespace Tpd.Core.Handler.ResultCore
{
    public interface IResultCore<T>
    {
        bool Success { get; set; }
        List<string> ErrorMessages { get; set; }
        T Result { get; set; }
    }
}
