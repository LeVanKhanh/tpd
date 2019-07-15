using MediatR;
using System.Collections.Generic;

namespace Tpd.Core.Domain.RequestCore.CommandCore
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
