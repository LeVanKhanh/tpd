using Tpd.Core.Data;

namespace Tpd.Language.Data.Entities
{
    public class Application : EntityCore
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
