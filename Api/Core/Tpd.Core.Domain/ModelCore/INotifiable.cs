using MediatR;
using System.Collections.Generic;

namespace Tpd.Core.Domain.ModelCore
{
    public interface INotifiable
    {
        List<INotification> Notifications { get; set; }
    }
}
