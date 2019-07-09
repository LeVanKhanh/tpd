using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.CommandHandlerBase
{
    public abstract class CommandHandlerBase<TCommand> : CommandHandlerCore<TCommand>
        where TCommand : ICommandCore
    {
        protected new DatabaseContext Data { get; set; }
        public CommandHandlerBase(DatabaseContext data)
          : base(data)
        {
            Data = data;
        }
    }
}
