using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandCreateHandlerBase<TCommand, TEntity, TModel> : CommandCreateHandlerCore<TCommand, TEntity, TModel>
        where TCommand : ICommandCreateCore<TModel>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandCreateHandlerBase(DatabaseWriteContext data, IMapper mapper)
          : base(data, mapper)
        {
            Data = data;
        }
    }
}
