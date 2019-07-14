using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public abstract class CommandHandlerBase<TCommand> : CommandHandlerCore<TCommand>
        where TCommand : ICommandCore
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandHandlerBase(DatabaseWriteContext data, IValidationService validationService)
          : base(data, validationService)
        {
            Data = data;
        }
    }
}
