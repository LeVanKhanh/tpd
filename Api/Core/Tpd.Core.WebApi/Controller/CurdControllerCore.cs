using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.QueryCore;

namespace Tpd.Core.WebApi.Controller
{
    public abstract class CurdControllerCore<TModelCreate, TModelUpdate, TGetItemResponse, TGetItemsResponse, TQuery> : ControllerCore
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
        where TQuery : IQueryListCore<TGetItemsResponse>
    {
        protected IDomainMediator<TModelCreate, TModelUpdate, TGetItemResponse, TGetItemsResponse, TQuery> DomainMediator { get; set; }
        public CurdControllerCore(IDomainMediator<TModelCreate, TModelUpdate, TGetItemResponse, TGetItemsResponse, TQuery> domainMediator)
           : base(domainMediator.Mediator)
        {
            DomainMediator = domainMediator;
        }

        [HttpPut]
        public async Task<ActionResult> Put(TModelCreate model)
        {
            var result = await DomainMediator.Create(model);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(TModelUpdate model)
        {
            var result = await DomainMediator.Update(model);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(Guid id)
        {
            var resut = await DomainMediator.Remove(id);
            return Ok(resut);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetItem(Guid id)
        {
            var result = await DomainMediator.GetItem(id);
            return Ok(result);
        }

        [HttpPost("GetItems")]
        public async Task<ActionResult> GetItems([FromBody]TQuery query)
        {
            var result = await DomainMediator.GetItems(query);
            return Ok(result);
        }
    }
}