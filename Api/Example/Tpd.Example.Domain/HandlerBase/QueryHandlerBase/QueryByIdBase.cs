using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public class QueryByIdBase<TEntity, TResponse> : QueryByIdCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseContextCore Data;
        public QueryByIdBase(DatabaseReadContext data, IMapper mapper) : base(data, mapper)
        {
            Data = data;
        }
    }
}
