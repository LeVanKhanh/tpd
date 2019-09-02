using MediatR;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Core.Handler.RequestCore.CommandCore;
using Tpd.Quiz.Data;

namespace Tpd.Quiz.Handler.HandlerBase.CommandHandlerBase
{
    public abstract class CommandHandlerBase<TCommand> : CommandHandlerCore<TCommand>
        where TCommand : ICommandCore
    {
        protected new DatabaseContext Data { get; set; }
        public CommandHandlerBase(DatabaseContext data, IValidationService validationService, IMediator mediator)
          : base(data, validationService, mediator)
        {
            Data = data;
        }
    }
}
