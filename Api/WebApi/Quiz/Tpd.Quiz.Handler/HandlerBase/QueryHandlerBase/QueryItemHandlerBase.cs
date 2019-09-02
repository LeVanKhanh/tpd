using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.QueryHandlerCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase
{
    public class QueryItemHandlerBase<TEntity, TResponse> : QueryItemHandlerCore<TEntity, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected new readonly DatabaseContext Data;
        public QueryItemHandlerBase(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService, mapper)
        {
            Data = data;
        }
    }
}
