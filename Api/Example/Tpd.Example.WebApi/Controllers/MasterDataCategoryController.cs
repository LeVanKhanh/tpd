using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;
using Tpd.Example.Domain.MasterDataCategoryDomain.Result;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataCategoryController
        : CurdControllerCore<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryResult,
        MasterDataCategoryResult, GetMasterDataCategoriesQuery>
    {
        public MasterDataCategoryController(IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryResult,
            MasterDataCategoryResult, GetMasterDataCategoriesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
