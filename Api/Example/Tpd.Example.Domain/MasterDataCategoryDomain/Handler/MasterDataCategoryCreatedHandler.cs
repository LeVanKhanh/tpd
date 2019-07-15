using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tpd.Example.Domain.MasterDataCategoryDomain.Notification;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategoryCreatedHandler : INotificationHandler<MasterDataCategoryCreatedNotifcation>
    {
        public MasterDataCategoryCreatedHandler() {

        }

        public Task Handle(MasterDataCategoryCreatedNotifcation notification, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
