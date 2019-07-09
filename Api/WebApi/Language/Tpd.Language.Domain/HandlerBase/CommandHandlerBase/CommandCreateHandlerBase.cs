using AutoMapper;
using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Language.Data;

namespace Tpd.Language.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandCreateHandlerBase<TEntity, TModel> : CommandCreateHandlerCore<TEntity, TModel>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected new DatabaseContext Data { get; set; }
        public CommandCreateHandlerBase(DatabaseContext data, IMapper mapper)
          : base(data, mapper)
        {
            Data = data;
        }
    }
}
