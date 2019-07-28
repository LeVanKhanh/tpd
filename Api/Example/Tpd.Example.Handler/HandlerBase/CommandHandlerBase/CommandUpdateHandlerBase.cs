using AutoMapper;
using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Core.Handler.ModelCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Handler.HandlerBase.CommandHandlerBase
{
    public class CommandUpdateHandlerBase<TEntity, TMolde> : CommandUpdateHandlerCore<TEntity, TMolde>
        where TEntity : EntityCore
        where TMolde : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandUpdateHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMediator mediator, IMapper mapper)
          : base(data, validationService, mediator, mapper)
        {
            Data = data;
        }
    }
}
