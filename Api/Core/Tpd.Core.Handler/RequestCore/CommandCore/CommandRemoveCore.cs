using System;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public class CommandRemoveCore : CommandCore, ICommandRemoveCore
    {
        public Guid Id { get; set; }
    }
}
