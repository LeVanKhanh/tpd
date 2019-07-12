using System;

namespace Tpd.Language.Domain.ModuleResourceDomain.Result
{
    public class GetModuleResourcesResult
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ResourceDefaultId { get; set; }
        public string ApplicationName { get; set; }
        public string ModuleName { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
        public string ResourceDescription { get; set; }
    }
}
