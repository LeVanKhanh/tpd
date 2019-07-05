using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public class QueryItemsHandlerBase<TEntity, TResponse> : QueryItemsHandlerCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryItemsHandlerBase(DatabaseReadContext data, IMapper mapper)
            : base(data, mapper)
        {
            Data = data;
        }
    }
}
