using System;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public interface ICommandRemoveCore : ICommandCore
    {
        Guid Id { get; set; }
    }
}
