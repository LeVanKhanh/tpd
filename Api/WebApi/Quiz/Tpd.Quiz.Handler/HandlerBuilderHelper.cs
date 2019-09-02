using Microsoft.Extensions.DependencyInjection;
using Tpd.Core.Handler;
using Tpd.Quiz.Handler.HandlerBase.CommandHandlerBase;
using Tpd.Quiz.Handler.HandlerBase.QueryHandlerBase;

namespace Tpd.Quiz.Handler
{
    public static class HandlerBuilderHelper
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddDomain(typeof(HandlerBuilderHelper),
                typeof(CommandCreateHandlerBase<,>),
                typeof(CommandUpdateHandlerBase<,>),
                typeof(CommandRemoveHandlerBase<>),
                typeof(QueryItemHandlerBase<,>));
        }
    }
}
