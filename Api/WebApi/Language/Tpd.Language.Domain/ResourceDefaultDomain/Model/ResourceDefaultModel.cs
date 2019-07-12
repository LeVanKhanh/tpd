using System;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Language.Domain.ResourceDefaultDomain.Model
{
    public class ResourceDefaultModel:IEntityModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
