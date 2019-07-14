using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.RequestCore.CommandCore;

namespace Tpd.Core.Domain.HandlerCore.CommandHandlerCore
{
    public abstract class CommandRemoveHandlerCore<TEntity> : CommandHandlerCore<ICommandRemoveCore>
        where TEntity : EntityCore
    {
        protected DbSet<TEntity> Entity;
        public CommandRemoveHandlerCore(DatabaseContextCore db, IValidationService validationService)
            : base(db, validationService)
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
