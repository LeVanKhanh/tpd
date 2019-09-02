using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TEntity> : CommandRemoveHandlerCore<TEntity>
        where TEntity : EntityCore
    {
        protected new DatabaseContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseContext data, IValidationService validationService, IMediator mediator)
          : base(data, validationService, mediator)
        {
            Data = data;
        }
    }
}
