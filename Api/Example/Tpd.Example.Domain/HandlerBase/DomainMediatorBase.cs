using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;
using Tpd.Example.Domain.HandlerBase.QueryHandlerBase;

namespace Tpd.Example.Domain.HandlerBase
{
    public abstract class DomainMediatorBase : DomainMediatorCore
    {
        public DomainMediatorBase(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {
        }

        protected async Task<int> Create<TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : IEntityModel
        {
            return await Create<CommandCreateHandlerBase<TEntity, TModel>, TEntity, TModel>(model);
        }

        protected async Task<int> Update<TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : IEntityModel
        {
            return await Update<CommandUpdateHandlerBase<TEntity, TModel>, TEntity, TModel>(model);
        }

        protected async Task<int> Remove<TEntity>(Guid id)
            where TEntity : EntityCore
        {
            return await Remove<CommandRemoveHandlerBase<TEntity>, TEntity>(id);
        }

        protected async Task<TResponse> GetItem<TEntity, TResponse>(Guid id)
            where TEntity : EntityCore
            where TResponse : new()
        {
            return await GetItem<QueryItemHandlerBase<TEntity, TResponse>, TEntity, TResponse>(id);
        }
    }
}
