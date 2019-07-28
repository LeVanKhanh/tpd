using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Tpd.Example.Data.Read;
using Tpd.Example.Data.Read.Entities;
using Tpd.Example.Handler.MasterDataCategoryDomain.Notification;

namespace Tpd.Example.Handler.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategorySavedHandler : INotificationHandler<MasterDataCategoryCreatedNotifcation>
    {
        private DatabaseReadContext _data { get; set; }
        public MasterDataCategorySavedHandler(DatabaseReadContext data)
        {
            _data = data;
        }

        public async Task Handle(MasterDataCategoryCreatedNotifcation notification, CancellationToken cancellationToken)
        {
            var entity = _data.MasterDataCategory.Find(notification.Id);
            var isAddNew = entity == null;
            if (isAddNew)
            {
                entity = new MasterDataCategory
                {
                    Id = notification.Id,
                    CreatedAt = DateTime.Now,
                };
            }

            entity.Description = notification.Description;
            entity.Name = notification.Name;
            entity.UpdatedAt = DateTime.Now;

            if (isAddNew)
            {
                _data.MasterDataCategory.Add(entity);
            }
            else
            {
                _data.MasterDataCategory.Update(entity);
            }

            _data.SaveChanges();
        }
    }
}
