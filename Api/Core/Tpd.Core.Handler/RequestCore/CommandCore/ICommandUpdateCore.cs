using Tpd.Core.Handler.ModelCore;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public interface ICommandUpdateCore<TModel> : ICommandCore
        where TModel : IEntityModel
    {
        TModel Model { get; set; }
    }
}
