using MediatR;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.HandlerCore.CommandHandlerCore;
using Tpd.Core.Handler.RequestCore.CommandCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Handler.HandlerBase.CommandHandlerBase
{
    public abstract class CommandHandlerBase<TCommand> : CommandHandlerCore<TCommand>
        where TCommand : ICommandCore
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMediator mediator)
          : base(data, validationService, mediator)
        {
            Data = data;
        }
    }
}
