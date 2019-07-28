using MediatR;
using System;
using Tpd.Core.Handler.ModelCore;
using Tpd.Example.Handler.MasterDataCategoryDomain.Notification;

namespace Tpd.Example.Handler.MasterDataCategoryDomain.Model
{
    public class MasterDataCategoryModel : IEntityModel, INotifiable
    {
        public MasterDataCategoryModel()
        {
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public INotification Notification
        {
            get
            {
                return new MasterDataCategoryCreatedNotifcation
                {
                    Id = Id,
                    Description = Description,
                    Name = Name
                };
            }
            set { }
        }
    }
}
