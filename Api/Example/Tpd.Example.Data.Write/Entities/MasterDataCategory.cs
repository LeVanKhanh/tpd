using System.ComponentModel.DataAnnotations.Schema;
using Tpd.Core.Data;

namespace Tpd.Example.Data.Write.Entities
{
    [Table("MasterDataCategory")]
    public class MasterDataCategory : EntityCore
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
