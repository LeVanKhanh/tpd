using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public class CommandCreateCore<TModel> : CommandCore, ICommandCreateCore<TModel>
        where TModel : ICreatable
    {
        public TModel Model { get; set; }
    }
}
