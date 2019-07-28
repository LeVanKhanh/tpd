using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Language.Domain.ModuleDomain.Model
{
    public class ModuleModel: IEntityModel
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string ApplicationShortName { get; set; }
        public string ApplicationFullName { get; set; }
        public string Name { get; set; }
    }
}
