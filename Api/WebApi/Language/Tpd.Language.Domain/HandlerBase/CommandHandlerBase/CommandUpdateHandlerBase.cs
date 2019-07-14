using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandUpdateHandlerBase<TEntity, TMolde> : CommandUpdateHandlerCore<TEntity, TMolde>
        where TEntity : EntityCore
        where TMolde : IEntityModel
    {
        protected new DatabaseContext Data { get; set; }
        public CommandUpdateHandlerBase(DatabaseContext data, IValidationService validationService, IMapper mapper)
          : base(data, validationService, mapper)
        {
            Data = data;
        }
    }
}
