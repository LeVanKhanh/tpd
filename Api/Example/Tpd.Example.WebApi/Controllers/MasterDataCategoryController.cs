using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataCategoryController : CurdControllerCore<MasterDataCategoryModel, MasterDataCategoryModel>
    {
        public MasterDataCategoryController(IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel> domainMediator)
            : base(domainMediator)
        {
        }

        [HttpPut]
        public async Task Put(MasterDataCategoryModel model)
        {
            var resut = await DomainMediator.Create(model);
        }

        [HttpPost]
        public async Task Post(MasterDataCategoryModel model)
        {
            var resut = await DomainMediator.Update(model);
        }

        [HttpDelete]
        public async Task Remove(Guid id)
        {
            var resut = await DomainMediator.Remove(id);
        }
    }
}
