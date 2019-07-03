using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandUpdateHandlerBase<TCommand, TEntity, TMolde> : CommandUpdateHandlerCore<TCommand, TEntity, TMolde>
        where TCommand : ICommandUpdateCore<TMolde>
        where TEntity : EntityCore
        where TMolde : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandUpdateHandlerBase(DatabaseWriteContext data, IMapper mapper)
          : base(data, mapper)
        {
            Data = data;
        }
    }
}
