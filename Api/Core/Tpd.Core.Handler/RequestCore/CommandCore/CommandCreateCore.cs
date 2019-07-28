using Tpd.Core.Handler.ModelCore;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public class CommandCreateCore<TModel> : CommandCore, ICommandCreateCore<TModel>
        where TModel : IEntityModel
    {
        public TModel Model { get; set; }
    }
}
