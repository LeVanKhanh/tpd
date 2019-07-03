using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TCommand, TEntity> : CommandRemoveHandlerCore<TCommand, TEntity>
        where TCommand : ICommandRemoveCore
        where TEntity : EntityCore
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseWriteContext data)
          : base(data)
        {
            Data = data;
        }
    }
}
