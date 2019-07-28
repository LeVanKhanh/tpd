using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Handler;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;
using Tpd.Example.Domain.HandlerBase.QueryHandlerBase;

namespace Tpd.Example.Domain
{
    public static class DomainBuilderHelper
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddDomain(typeof(DomainBuilderHelper),
                typeof(CommandCreateHandlerBase<,>),
                typeof(CommandUpdateHandlerBase<,>),
                typeof(CommandRemoveHandlerBase<>),
                typeof(QueryItemHandlerBase<,>));
        }
    }
}