using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TCommand, TEntity> : CommandRemoveHandlerCore<TCommand, TEntity>
        where TCommand : ICommandRemoveCore
        where TEntity : EntityCore
    {
        protected new DatabaseContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseContext data)
          : base(data)
        {
            Data = data;
        }
    }
}
