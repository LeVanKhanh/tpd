using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Share;

namespace Tpd.Core.Domain.HandlerCore.CommandHandlerCore
{
    public abstract class CommandCreateHandlerCore<TCommand, TEntity, TModel> : CommandHandlerCore<TCommand>
        where TCommand : ICommandCreateCore<TModel>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected readonly IMapper Mapper;
        protected DbSet<TEntity> Entity;
        public CommandCreateHandlerCore(DatabaseContextCore db, IMapper mapper)
            : base(db)
        {
            Entity = Data.Set<TEntity>();
            Mapper = mapper;
        }

        protected override async Task<bool> TryBuildCommand(TCommand command, RequestContextCore Context)
        {
            var entity = await CreateEntity(command);
            Entity.AddWithContext(Context, entity);
            return true;
        }

        protected virtual async Task<TEntity> CreateEntity(TCommand command)
        {
            return Mapper.Map<TEntity>(command.Model);
        }

        protected override async Task<bool> IsValid(TCommand command)
        {
            if (Exists(command))
            {
                command.Messages.Add(Constants.CommonMessages.THE_ITEM_EXIST);
                return false;
            }
            return true;
        }

        protected virtual bool Exists(TCommand command)
        {
            return Data.Set<TEntity>().Where(w => w.Id == command.Model.Id).Any();
        }
    }
}
