using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
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
