using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Core.Handler.RequestCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public abstract class QueryHandlerBase<TQuery, TResponse> : QueryHandlerCore<TQuery, TResponse>
        where TQuery : IRequestCore<TResponse>
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryHandlerBase(DatabaseReadContext data, IValidationService validationService)
           : base(data, validationService)
        {
            Data = data;
        }
    }
}
