using System;
using Tpd.Core.Data;

namespace Tpd.Language.Data.Entities
{
    public class ModuleResource : EntityCore
    {
        public Guid ModuleId { get; set; }
        public Guid ResourceDefaultId { get; set; }
        public Module Module { get; set; }
        public ResourceDefault Baseline { get; set; }
    }
}
