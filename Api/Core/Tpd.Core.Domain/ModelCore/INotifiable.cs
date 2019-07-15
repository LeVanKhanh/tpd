using MediatR;

namespace Tpd.Core.Domain.ModelCore
{
    public interface INotifiable
    {
        INotification Notification { get; set; }
    }
}
