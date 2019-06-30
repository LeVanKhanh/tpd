using System;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public interface ICommandRemoveCore : ICommandCore
    {
        Guid Id { get; set; }
    }
}
