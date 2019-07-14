using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TEntity> : CommandRemoveHandlerCore<TEntity>
        where TEntity : EntityCore
    {
        protected new DatabaseContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseContext data, IValidationService validationService)
          : base(data, validationService)
        {
            Data = data;
        }
    }
}
