using Microsoft.EntityFrameworkCore;
using Tpd.Core.Data;
using Tpd.Example.Data.Write.Entities;

namespace Tpd.Example.Data.Write
{
    public class DatabaseWriteContext : DatabaseContextCore
    {
        public DatabaseWriteContext(DbContextOptions<DatabaseWriteContext> options)
           : base(options)
        {

        }

        public DbSet<MasterDataCategory> MasterDataCategory { get; set; }
    }
}
