using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

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
        public async Task Put(TModelCreate model)
        {
            var resut = await DomainMediator.Create(model);
        }

        [HttpPost]
        public async Task Post(TModelUpdate model)
        {
            var resut = await DomainMediator.Update(model);
        }

        [HttpDelete]
        public async Task Remove(Guid id)
        {
            var resut = await DomainMediator.Remove(id);
        }

        [HttpGet("id")]
        public async Task<TGetItemResponse> GetItem(Guid id)
        {
            var result = await DomainMediator.GetItem(id);
            return result;
        }

        [HttpPost("GetItems")]
        public async Task<IResultCore<PagedResultCore<TGetItemsResponse>>> GetItems([FromBody]TQuery query)
        {
            var result = await DomainMediator.GetItems(query);
            return result;
        }
    }
}