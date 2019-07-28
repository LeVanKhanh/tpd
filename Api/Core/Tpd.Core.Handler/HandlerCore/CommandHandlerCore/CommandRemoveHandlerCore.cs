using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore.CommandCore;

namespace Tpd.Core.Handler.HandlerCore.CommandHandlerCore
{
    public abstract class CommandRemoveHandlerCore<TEntity> : CommandHandlerCore<ICommandRemoveCore>
        where TEntity : EntityCore
    {
        protected DbSet<TEntity> Entity;
        public CommandRemoveHandlerCore(DatabaseContextCore db, IValidationService validationService, IMediator mediator)
            : base(db, validationService, mediator)
        {
            Entity = Data.Set<TEntity>();
        }

        protected override async Task<bool> TryBuildCommand(ICommandRemoveCore command, RequestContextCore Context)
        {
            var oldEntity = await Entity.FindAsync(command.Id);
            if (oldEntity != null)
            {
                Entity.Remove(oldEntity);
            }
            return true;
        }
    }
}
