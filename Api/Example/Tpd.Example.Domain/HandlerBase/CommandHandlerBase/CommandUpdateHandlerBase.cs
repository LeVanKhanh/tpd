using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandUpdateHandlerBase<TEntity, TMolde> : CommandUpdateHandlerCore<TEntity, TMolde>
        where TEntity : EntityCore
        where TMolde : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandUpdateHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMapper mapper)
          : base(data, validationService, mapper)
        {
            Data = data;
        }
    }
}
