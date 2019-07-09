using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Request
{
    public class GetMasterDataCategoriesQuery: QueryListCore<MasterDataCategoryModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
