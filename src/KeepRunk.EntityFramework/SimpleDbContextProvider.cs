using System.Data.Entity;

namespace KeepRunk.EntityFramework
{
    public class SimpleDbContextProvider<TDbContext> : IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        public TDbContext DbContext { get; private set; }

        public SimpleDbContextProvider(TDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public TDbContext GetDbContext()
        {
            return DbContext;
        }
    }
}