using System;
using Tpd.Core.Data;

namespace Tpd.Language.Data.Entities
{
    public class Translation : EntityCore
    {
        public Guid ResourceDefaultId { get; set; }
        public Guid CultureId { get; set; }
        public string Display { get; set; }
        public ResourceDefault ResourceDefault { get; set; }
        public Culture Culture { get; set; }
    }
}
