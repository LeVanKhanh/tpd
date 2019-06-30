using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;

namespace Tpd.Example.Domain
{
    public class DomainResolver
    {
        public IMediator Mediator { get; private set; }
        public DomainResolver(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<int> Create<TCommand, TEntity, TModel>(TModel model)
            where TEntity : EntityCore
            where TModel : ICreatable
        {

            var command = MyServiceProvider.ServiceProvider.GetService<ICommandCreateCore<TModel>>();
            var handler = MyServiceProvider.ServiceProvider.GetService<CommandCreateHandlerBase<ICommandCreateCore<TModel>, TEntity, TModel>>();
            command.Model = model;
            var result = await handler.Handle(command);
            return result.Result;
        }
    }
}
