using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Example.Data.Read;

namespace Tpd.Example.Domain.HandlerBase.QueryHandlerBase
{
    public class QueryItemHandlerBase<TEntity, TResponse> : QueryItemHandlerCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseReadContext Data;
        public QueryItemHandlerBase(DatabaseReadContext data, IValidationService validationService, IMapper mapper) : base(data, validationService, mapper)
        {
            Data = data;
        }
    }
}
