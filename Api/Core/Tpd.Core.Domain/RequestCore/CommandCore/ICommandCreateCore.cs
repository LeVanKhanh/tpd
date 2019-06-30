using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public interface ICommandCreateCore<TModel> : ICommandCore
        where TModel: ICreatable
    {
        TModel Model { get; set; }
    }
}
