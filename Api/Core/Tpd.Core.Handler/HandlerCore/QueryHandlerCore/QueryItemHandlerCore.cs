﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore.QueryCore;

namespace Tpd.Core.Handler.HandlerCore.QueryHandlerCore
{
    public abstract class QueryItemHandlerCore<TEntity, TResponse> : QuerySingleHandlerCore<IQueryItemCore<TResponse>, TResponse>
        where TEntity : EntityCore
        where TResponse : new()
    {
        protected DbSet<TEntity> Entities;
        protected IMapper Mapper;
        public QueryItemHandlerCore(DatabaseContextCore data, IValidationService validationService, IMapper mapper) : base(data, validationService)
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
