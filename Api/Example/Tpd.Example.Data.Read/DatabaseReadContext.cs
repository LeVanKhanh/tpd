using Microsoft.EntityFrameworkCore;
using Tpd.Core.Data;
using Tpd.Example.Data.Read.Entities;

namespace Tpd.Example.Data.Read
{
    public class DatabaseReadContext : DatabaseContextCore
    {
        public DatabaseReadContext(DbContextOptions<DatabaseReadContext> options)
            : base(options)
        {

        }

        public DbSet<MasterDataCategory> MasterDataCategory { get; set; }
    }
}
