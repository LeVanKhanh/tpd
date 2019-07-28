using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Handler.HandlerBase.QueryHandlerBase
{
    public abstract class QueryListHandlerBase<TQuery, TResponse> : QueryListHandlerCore<TQuery, TResponse>
        where TQuery : IQueryListCore<TResponse>
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryListHandlerBase(DatabaseReadContext data, IValidationService validationService)
            : base(data, validationService)
        {
            Data = data;
        }
    }
}
