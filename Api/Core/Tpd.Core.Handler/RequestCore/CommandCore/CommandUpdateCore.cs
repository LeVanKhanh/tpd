using Tpd.Core.Handler.ModelCore;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public class CommandUpdateCore<TModel> : CommandCore, ICommandUpdateCore<TModel>
        where TModel : IEntityModel
    {
        public TModel Model { get; set; }
    }
}
