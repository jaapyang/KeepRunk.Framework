using System.Data.Entity;

namespace KeepRunk.EntityFramework
{
    public interface IRepositoryWithDbContext
    {
        DbContext GetDbContext();
    }
}