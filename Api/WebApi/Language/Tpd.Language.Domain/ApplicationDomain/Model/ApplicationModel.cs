using System;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Language.Domain.ApplicationDomain.Model
{
    public class ApplicationModel : IEntityModel
    {
        public Guid Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
