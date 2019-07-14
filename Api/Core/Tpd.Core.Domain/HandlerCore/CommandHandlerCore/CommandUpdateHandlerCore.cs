﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Share;

namespace Tpd.Core.Domain.HandlerCore.CommandHandlerCore
{
    public abstract class CommandUpdateHandlerCore<TEntity, TMolde> : CommandHandlerCore<ICommandUpdateCore<TMolde>>
        where TEntity : EntityCore
        where TMolde : IEntityModel

    {
        protected readonly IMapper Mapper;
        protected DbSet<TEntity> Entity;

        public CommandUpdateHandlerCore(DatabaseContextCore data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            Entity = Data.Set<TEntity>();
            Mapper = mapper;
        }

        protected override async Task<bool> TryBuildCommand(ICommandUpdateCore<TMolde> command, RequestContextCore Context)
        {
            var oldEntity = await GetOldEntityAsync(command);

            if (oldEntity == null)
            {
                command.Messages.Add(Constants.CommonMessages.THE_ITEM_DOES_NOT_EXIST);
                return false;
            }

            var newEntity = await CreateNewEntityAsync(oldEntity, command);
            Entity.UpdateWithContext(Context, newEntity);
            return true;
        }

        protected virtual async Task<TEntity> GetOldEntityAsync(ICommandUpdateCore<TMolde> command)
        {
            return await Entity.FindAsync(command.Model.Id);
        }

        protected virtual async Task<TEntity> CreateNewEntityAsync(TEntity oldEntity, ICommandUpdateCore<TMolde> command)
        {
            var createdAt = oldEntity.CreatedAt;
            var entity = Mapper.Map(command.Model, oldEntity);
            entity.CreatedAt = createdAt;
            return entity;
        }
    }
}
