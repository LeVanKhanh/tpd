using System;
using Tpd.Core.Handler.ModelCore;

namespace Tpd.Language.Domain.CultureDomain.Model
{
    public class CultureModel : IEntityModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
