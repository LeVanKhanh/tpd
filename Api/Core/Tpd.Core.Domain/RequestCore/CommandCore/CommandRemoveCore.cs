using System;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public class CommandRemoveCore : CommandCore, ICommandRemoveCore
    {
        public Guid Id { get; set; }
    }
}
