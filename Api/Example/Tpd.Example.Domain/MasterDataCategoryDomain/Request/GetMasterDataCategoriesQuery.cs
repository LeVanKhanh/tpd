using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Example.Domain.MasterDataCategoryDomain.Result;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Request
{
    public class GetMasterDataCategoriesQuery: QueryListCore<MasterDataCategoryResult>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
