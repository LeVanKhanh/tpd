using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataCategoryController : CurdControllerCore<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel, GetMasterDataCategoriesQuery>
    {
        public MasterDataCategoryController(IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel, GetMasterDataCategoriesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
