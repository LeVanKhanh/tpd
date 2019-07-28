using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore.QueryCore;

namespace Tpd.Core.Handler.HandlerCore.QueryHandlerCore
{
    public abstract class QueryItemsHandlerCore<TEntity, TResponse> : QueryListHandlerCore<IQueryItemsCore<TResponse>, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected DbSet<TEntity> Entities;
        protected IMapper Mapper;
        public QueryItemsHandlerCore(DatabaseContextCore data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            Entities = data.Set<TEntity>();
            Mapper = mapper;
        }

        protected override async Task<IQueryable<TResponse>> BuildQueryAsync(IQueryItemsCore<TResponse> query, RequestContextCore context)
        {
            return Entities.ProjectTo<TResponse>(Mapper.ConfigurationProvider);
        }
    }
}
