using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.WebApi.Controller
{
    public class CurdControllerCore<TModelCreate, TModelUpdate, TResponse> : ControllerCore
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
    {
        protected IDomainMediator<TModelCreate, TModelUpdate, TResponse> DomainMediator { get; set; }
        public CurdControllerCore(IDomainMediator<TModelCreate, TModelUpdate, TResponse> domainMediator)
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
        public async Task<TResponse> GetItem(Guid id)
        {
            var result = await DomainMediator.GetItem(id);
            return result;
        }
    }
}