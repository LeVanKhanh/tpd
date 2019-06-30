using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public class CommandUpdateCore<TModel> : CommandCore, ICommandUpdateCore<TModel>
        where TModel : ICreatable
    {
        public TModel Model { get; set; }
    }
}
