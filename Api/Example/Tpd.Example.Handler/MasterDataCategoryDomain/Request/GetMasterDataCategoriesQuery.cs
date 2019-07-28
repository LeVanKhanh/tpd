using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Example.Handler.MasterDataCategoryDomain.Result;

namespace Tpd.Example.Handler.MasterDataCategoryDomain.Request
{
    public class GetMasterDataCategoriesQuery: QueryListCore<MasterDataCategoryResult>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
