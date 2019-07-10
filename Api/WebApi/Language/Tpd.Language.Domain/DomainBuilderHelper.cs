using Microsoft.Extensions.DependencyInjection;
using Tpd.Language.Domain.HandlerBase.CommandHandlerBase;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Core.Domain;

namespace Tpd.Language.Domain
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
