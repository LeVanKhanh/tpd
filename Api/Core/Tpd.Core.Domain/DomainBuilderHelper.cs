using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Tpd.Core.Domain
{
    public static class DomainBuilderHelperCore
    {
        public static void AddDomain(this IServiceCollection services, [NotNull] DomainBuilderHelperOptions options)
        {
            if (options == null)
            {
                throw new Exception();
            }

            switch (options.DataProvider)
            {
                case DomainBuilderHelperOptions.DataTypeProvider.Sql:

                    break;
            };
        }
    }
}
