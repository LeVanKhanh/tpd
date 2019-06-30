using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.RequestCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Example.Data.Write.Entities;
using Tpd.Example.Domain;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.Request.MasterDataCategoryRequest;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataCategoryController : ControllerBase
    {
        private readonly DomainResolver _domainResolver;
        public MasterDataCategoryController(DomainResolver domainResolver)
        {
            _domainResolver = domainResolver;
        }

        [HttpPut]
        public async Task Put(MasterDataCategoryModel model)
        {
            var resut = await _domainResolver.Create<CreateMasterDataCategoryCommand, MasterDataCategory, MasterDataCategoryModel>(model);
        }
    }
}
