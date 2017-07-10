using System.Data.Entity;

namespace KeepRunk.EntityFramework
{
    public interface IDbContextProvider<out TDbContext>
        where TDbContext:DbContext
    {
        TDbContext GetDbContext();
    }
}