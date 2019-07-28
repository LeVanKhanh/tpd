using MediatR;
using System.Collections.Generic;

namespace Tpd.Core.Handler.RequestCore.CommandCore
{
    public interface ICommandCore : IRequestCore<int>
    {
        List<INotification> Notifications { get; set; }
    }
}
