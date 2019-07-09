using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.QueryHandlerBase
{
    public class QueryItemHandlerBase<TEntity, TResponse> : QueryItemHandlerCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseContext Data;
        public QueryItemHandlerBase(DatabaseContext data, IMapper mapper) : base(data, mapper)
        {
            Data = data;
        }
    }
}
