using MediatR;
using System;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Notification
{
    public class MasterDataCategoryCreatedNotifcation: INotification
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
