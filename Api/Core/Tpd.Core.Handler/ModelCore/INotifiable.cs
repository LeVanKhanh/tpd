using MediatR;

namespace Tpd.Core.Handler.ModelCore
{
    public interface INotifiable
    {
        INotification Notification { get; set; }
    }
}
