using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Handler.HandlerBase.QueryHandlerBase
{
    public abstract class QuerySingleHandlerBase<TQuery, TResponse> : QueryHandlerCore<TQuery, TResponse>
        where TQuery : IQuerySingleCore<TResponse>
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QuerySingleHandlerBase(DatabaseReadContext data, IValidationService validationService)
            : base(data, validationService)
        {
            Data = data;
        }
    }
}
