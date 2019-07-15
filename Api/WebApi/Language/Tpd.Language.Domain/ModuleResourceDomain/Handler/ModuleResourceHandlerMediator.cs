using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.HandlerBase;
using Tpd.Language.Domain.ModuleResourceDomain.Model;
using Tpd.Language.Domain.ModuleResourceDomain.Query;
using Tpd.Language.Domain.ModuleResourceDomain.Result;

namespace Tpd.Language.Domain.ModuleResourceDomain.Handler
{
    public class ModuleResourceHandlerMediator : DomainMediatorBase,
        IDomainMediator<ModuleResourceModel, ModuleResourceModel, ModuleResourceModel, GetModuleResourcesResult, GetModuleResourcesQuery>
    {
        public ModuleResourceHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
           : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(ModuleResourceModel model)
        {
            return await Create<ModuleResource, ModuleResourceModel>(model);
        }

        public async Task<IResultCore<int>> Update(ModuleResourceModel model)
        {
            return await Update<ModuleResource, ModuleResourceModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<ModuleResource>(id);
        }

        public async Task<IResultCore<ModuleResourceModel>> GetItem(Guid id)
        {
            return await GetItem<ModuleResource, ModuleResourceModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<GetModuleResourcesResult>>> GetItems(GetModuleResourcesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
