using System;

namespace Tpd.Language.Domain.ModuleDomain.Result
{
    public class GetModulesResult
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string ApplicationShortName { get; set; }
        public string ApplicationFullName { get; set; }
        public string Name { get; set; }
    }
}
