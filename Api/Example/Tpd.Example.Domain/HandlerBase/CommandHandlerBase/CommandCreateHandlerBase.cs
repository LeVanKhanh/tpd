﻿using AutoMapper;
using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Core.Handler.ModelCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandCreateHandlerBase<TEntity, TModel> : CommandCreateHandlerCore<TEntity, TModel>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandCreateHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMediator mediator, IMapper mapper)
          : base(data, validationService, mediator, mapper)
        {
            Data = data;
        }
    }
}
