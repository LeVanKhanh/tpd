using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public class CommandUpdateCore<TModel> : CommandCore, ICommandUpdateCore<TModel>
        where TModel : IEntityModel
    {
        public TModel Model { get; set; }
    }
}
