using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.RequestCore.QueryCore;

namespace Tpd.Core.Domain.HandlerCore.QueryHandlerCore
{
    public abstract class QueryItemHandlerCore<TEntity, TResponse> : QuerySingleHandlerCore<IQueryItemCore<TResponse>, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected DbSet<TEntity> Entities;
        protected IMapper Mapper;
        public QueryItemHandlerCore(DatabaseContextCore data, IMapper mapper) : base(data)
        {
            Entities = data.Set<TEntity>();
            Mapper = mapper;
        }

        protected override async Task<IQueryable<TResponse>> BuildQuery(IQueryItemCore<TResponse> query, RequestContextCore context)
        {
            return Entities.Where(w => w.Id == query.Id).ProjectTo<TResponse>(Mapper.ConfigurationProvider);
        }
    }
}
