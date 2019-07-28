using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Example.Handler.MasterDataCategoryDomain.Model;
using Tpd.Example.Handler.MasterDataCategoryDomain.Request;
using Tpd.Example.Handler.MasterDataCategoryDomain.Result;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataCategoryController
        : CurdControllerCore<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryResult,
        MasterDataCategoryResult, GetMasterDataCategoriesQuery>
    {
        public MasterDataCategoryController(IHandlerMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryResult,
            MasterDataCategoryResult, GetMasterDataCategoriesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
