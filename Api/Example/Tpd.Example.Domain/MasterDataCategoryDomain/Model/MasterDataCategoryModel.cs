using MediatR;
using System;
using Tpd.Core.Handler.ModelCore;
using Tpd.Example.Domain.MasterDataCategoryDomain.Notification;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Model
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
