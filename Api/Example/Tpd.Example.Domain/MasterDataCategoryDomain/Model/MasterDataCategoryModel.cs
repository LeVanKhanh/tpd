using System;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Model
{
    public class MasterDataCategoryModel : IEntityModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
