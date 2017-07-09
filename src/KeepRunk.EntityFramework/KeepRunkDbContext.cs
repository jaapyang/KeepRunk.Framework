using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepRunk.EntityFramework
{
    public abstract class KeepRunkDbContext : DbContext
    {
        protected KeepRunkDbContext()
        {
            InitializeDbContext();
        }
        protected KeepRunkDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            InitializeDbContext();
        }

        protected virtual void InitializeDbContext()
        {
            Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
