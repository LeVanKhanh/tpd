using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class MasterDataCategoryController : CurdControllerCore<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel>
    {
        public MasterDataCategoryController(IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
