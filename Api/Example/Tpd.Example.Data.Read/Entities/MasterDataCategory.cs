using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tpd.Core.Data;

namespace Tpd.Example.Data.Read.Entities
{
    [Table("MasterDataCategory")]
    public class MasterDataCategory: EntityCore
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
