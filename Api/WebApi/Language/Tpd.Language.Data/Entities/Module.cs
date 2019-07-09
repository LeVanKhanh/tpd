using System;
using Tpd.Core.Data;

namespace Tpd.Language.Data.Entities
{
    public class Module:EntityCore
    {
        public Guid ApplicationId { get; set; }
        public string Name { get; set; }
        public Application Application { get; set; }
    }
}
