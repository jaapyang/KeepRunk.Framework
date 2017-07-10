using System.Data.Common;
using System.Data.Entity;

namespace KeepRunk.EntityFramework
{
    public class DefaultDbContextResolver : IDbContextResolver
    {
        public TDbContext Resolve<TDbContext>(string connectionString) where TDbContext : DbContext
        {
            throw new System.NotImplementedException();
        }

        public TDbContext Resolve<TDbContext>(DbConnection existingConnection, bool contextOwnsConnection) where TDbContext : DbContext
        {
            throw new System.NotImplementedException();
        }
    }
}