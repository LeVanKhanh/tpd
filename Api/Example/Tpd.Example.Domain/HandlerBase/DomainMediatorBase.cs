﻿using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;

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
            return await Create<CommandCreateHandlerBase<ICommandCreateCore<TModel>, TEntity, TModel>, TEntity, TModel>(model);
        }

        protected async Task<int> Update<TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : IEntityModel
        {
            return await Update<CommandUpdateHandlerBase<ICommandUpdateCore<TModel>, TEntity, TModel>, TEntity, TModel>(model);
        }

        protected async Task<int> Remove<TEntity>(Guid id)
            where TEntity : EntityCore
        {
            return await Remove<CommandRemoveHandlerBase<ICommandRemoveCore, TEntity>, TEntity>(id);
        }
    }
}