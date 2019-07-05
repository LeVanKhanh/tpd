using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.HandlerCore.QueryHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore
{
    public abstract class DomainMediatorCore
    {
        public IMediator Mediator { get; set; }
        public IServiceProvider _serviceProvider { get; set; }
        public DomainMediatorCore(IServiceProvider serviceProvider, IMediator mediator)
        {
            Mediator = mediator;
            _serviceProvider = serviceProvider;
        }

        protected async Task<int> Create<THandler, TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : IEntityModel
            where THandler : CommandCreateHandlerCore<TEntity, TModel>
        {
            var command = _serviceProvider.GetService<ICommandCreateCore<TModel>>();
            var handler = _serviceProvider.GetService<THandler>();
            command.Model = model;
            var result = await handler.Handle(command);
            return result.Result;
        }

        protected async Task<int> Update<THandler, TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : IEntityModel
            where THandler : CommandUpdateHandlerCore<TEntity, TModel>
        {
            var command = _serviceProvider.GetService<ICommandUpdateCore<TModel>>();
            var handler = _serviceProvider.GetService<THandler>();
            command.Model = model;
            var result = await handler.Handle(command);
            return result.Result;
        }

        protected async Task<int> Remove<THandler, TEntity>(Guid id)
            where TEntity : EntityCore
            where THandler : CommandRemoveHandlerCore<TEntity>
        {
            var command = _serviceProvider.GetService<ICommandRemoveCore>();
            var handler = _serviceProvider.GetService<THandler>();
            command.Id = id;
            var result = await handler.Handle(command);
            return result.Result;
        }

        protected async Task<TResponse> GetItem<THandler, TEntity, TResponse>(Guid id)
            where THandler : QueryItemHandlerCore<TEntity, TResponse>
            where TEntity : EntityCore
            where TResponse : new()
        {
            var query = _serviceProvider.GetService<IQueryItemCore<TResponse>>();
            var handler = _serviceProvider.GetService<THandler>();
            query.Id = id;
            var result = await handler.Handle(query);
            return result.Result;
        }

        protected async Task<PagedResultCore<TResponse>> GetItems<THandler, TEntity, TResponse>()
            where THandler : QueryListHandlerCore<IQueryItemsCore<TResponse>, TResponse>
            where TEntity : EntityCore
            where TResponse : new()
        {
            var query = _serviceProvider.GetService<IQueryItemsCore<TResponse>>();
            var handler = _serviceProvider.GetService<THandler>();
            var result = await handler.Handle(query);
            return result.Result;
        }
    }
}
