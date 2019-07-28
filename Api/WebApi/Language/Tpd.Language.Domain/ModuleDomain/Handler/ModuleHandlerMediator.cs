using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.HandlerBase;
using Tpd.Language.Domain.ModuleDomain.Model;
using Tpd.Language.Domain.ModuleDomain.Request;
using Tpd.Language.Domain.ModuleDomain.Result;

namespace Tpd.Language.Domain.ModuleDomain.Handler
{
    public class ModuleHandlerMediator : DomainMediatorBase,
        IHandlerMediator<ModuleModel, ModuleModel, ModuleModel, GetModulesResult, GetModulesQuery>
    {
        public ModuleHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(ModuleModel model)
        {
            return await Create<Module, ModuleModel>(model);
        }

        public async Task<IResultCore<int>> Update(ModuleModel model)
        {
            return await Update<Module, ModuleModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<Module>(id);
        }

        public async Task<IResultCore<ModuleModel>> GetItem(Guid id)
        {
            return await GetItem<Module, ModuleModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<GetModulesResult>>> GetItems(GetModulesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
