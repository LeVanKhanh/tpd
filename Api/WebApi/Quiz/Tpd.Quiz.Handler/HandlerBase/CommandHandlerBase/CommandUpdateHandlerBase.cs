using AutoMapper;
using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Core.Handler.ModelCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.CommandHandlerBase
{
    public class CommandUpdateHandlerBase<TEntity, TMolde> : CommandUpdateHandlerCore<TEntity, TMolde>
        where TEntity : EntityCore
        where TMolde : IEntityModel
    {
        protected new DatabaseContext Data { get; set; }
        public CommandUpdateHandlerBase(DatabaseContext data, IValidationService validationService, IMediator mediator, IMapper mapper)
          : base(data, validationService, mediator, mapper)
        {
            Data = data;
        }
    }
}
