using System;
using System.Collections.Generic;
using MediatR;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Model
{
    public class MasterDataCategoryModel : IEntityModel, INotifiable
    {
        public MasterDataCategoryModel() {
            Notifications = new List<INotification>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<INotification> Notifications { get; set; }
    }
}
