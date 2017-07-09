using KeepRunk.Core.Entities;

namespace KeepRunk.Core.Repository
{
    public interface IRepository<TEntity> : IRepository<TEntity, int>
        where TEntity : class ,IEntity<int>
    {

    }
}