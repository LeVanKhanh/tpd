using Microsoft.EntityFrameworkCore;
using Tpd.Core.Data;
using Tpd.Language.Data.Entities;

namespace Tpd.Language.Data
{
    public class DatabaseContext : DatabaseContextCore
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        {

        }

        public DbSet<Application> Application { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<ModuleResource> ModuleResource { get; set; }
        public DbSet<ResourceDefault> ResourceDefault { get; set; }
        public DbSet<Translation> Translation { get; set; }
        public DbSet<Culture> Culture { get; set; }
    }
}
