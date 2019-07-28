using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public class QueryItemsHandlerBase<TEntity, TResponse> : QueryItemsHandlerCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryItemsHandlerBase(DatabaseReadContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService, mapper)
        {
            Data = data;
        }
    }
}
