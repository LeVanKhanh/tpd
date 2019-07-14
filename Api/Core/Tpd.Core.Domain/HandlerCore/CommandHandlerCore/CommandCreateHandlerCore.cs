using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Share;

namespace Tpd.Core.Domain.HandlerCore.CommandHandlerCore
{
    public abstract class CommandCreateHandlerCore<TEntity, TModel> : CommandHandlerCore<ICommandCreateCore<TModel>>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected readonly IMapper Mapper;
        protected DbSet<TEntity> Entity;
        public CommandCreateHandlerCore(DatabaseContextCore db, IValidationService validationService, IMapper mapper)
            : base(db, validationService)
        {
            Entity = Data.Set<TEntity>();
            Mapper = mapper;
        }

        protected override async Task<bool> TryBuildCommand(ICommandCreateCore<TModel> command, RequestContextCore Context)
        {
            var entity = await CreateEntity(command);
            var validationResult = ValidationService.Validate(entity);

            if (validationResult.IsValid)
            {
                Entity.AddWithContext(Context, entity);
            }
            else
            {
                command.Messages.AddRange(validationResult.Errors.Select(s => s.ErrorMessage));
            }

            return validationResult.IsValid;
        }

        protected virtual async Task<TEntity> CreateEntity(ICommandCreateCore<TModel> command)
        {
            return Mapper.Map<TEntity>(command.Model);
        }

        protected override async Task<bool> IsValid(ICommandCreateCore<TModel> command)
        {
            if (Exists(command))
            {
                command.Messages.Add(Constants.CommonMessages.THE_ITEM_EXIST);
                return false;
            }
            return true;
        }

        protected virtual bool Exists(ICommandCreateCore<TModel> command)
        {
            return Data.Set<TEntity>().Where(w => w.Id == command.Model.Id).Any();
        }
    }
}
