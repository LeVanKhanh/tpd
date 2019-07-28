﻿using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TEntity> : CommandRemoveHandlerCore<TEntity>
        where TEntity : EntityCore
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMediator mediator)
          : base(data, validationService, mediator)
        {
            Data = data;
        }
    }
}
