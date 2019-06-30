using System.Collections.Generic;

namespace Tpd.Core.Domain.ResultCore
{
    public class ResultCore<T> : IResultCore<T>
    {
        public ResultCore()
        {
            ErrorMessages = new List<string>();
        }
        public bool Success { get; set; }
        public T Result { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
