using Microsoft.EntityFrameworkCore;
using Tpd.Core.Data;

namespace Tpd.Example.Data.Read
{
    public class DatabaseReadContext : DatabaseContextCore
    {
        public DatabaseReadContext(DbContextOptions<DatabaseReadContext> options)
            : base(options)
        {

        }
    }
}
