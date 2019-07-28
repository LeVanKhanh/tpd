using MediatR;
using System.Collections.Generic;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public abstract class CommandCore : RequestCore, ICommandCore
    {
        public CommandCore()
        {
            Notifications = new List<INotification>();
        }
        public List<INotification> Notifications { get; set; }
    }
}
