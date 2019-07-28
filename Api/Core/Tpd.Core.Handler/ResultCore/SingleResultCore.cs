using System;
using System.Collections;

namespace Tpd.Core.Handler.ResultCore
{
    public class SingleResultCore<T> : ResultCore<T>, ISingleResultCore<T>
       where T : new()
    {
        public SingleResultCore()
        {
            var T = new T();
            if (T is IEnumerable)
            {
                throw new Exception();
            }
        }
    }
}
