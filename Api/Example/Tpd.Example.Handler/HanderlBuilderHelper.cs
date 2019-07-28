using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Handler;
using Tpd.Example.Handler.HandlerBase.CommandHandlerBase;
using Tpd.Example.Handler.HandlerBase.QueryHandlerBase;

namespace Tpd.Example.Handler
{
    public static class HanderlBuilderHelper
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddDomain(typeof(HanderlBuilderHelper),
                typeof(CommandCreateHandlerBase<,>),
                typeof(CommandUpdateHandlerBase<,>),
                typeof(CommandRemoveHandlerBase<>),
                typeof(QueryItemHandlerBase<,>));
        }
    }
}