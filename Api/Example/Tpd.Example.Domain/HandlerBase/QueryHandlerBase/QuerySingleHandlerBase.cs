using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
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
