using System.Data.Entity;
using System.Linq;
using KeepRunk.Core.Entities;
using KeepRunk.Core.Repository;

namespace KeepRunk.EntityFramework
{
    public class EfReporsitory<TDbContext, TEntity, TPrimaryKey>
        : RepositoryBase<TEntity, TPrimaryKey>,IRepositoryWithDbContext
        where TEntity : class ,IEntity<TPrimaryKey>
        where TDbContext : DbContext
    {
        public override IQueryable<TEntity> GetAll()
        {
            // TODO: implemente
            throw new System.NotImplementedException();
        }

        public override TEntity Insert(TEntity entity)
        {
            // TODO: implemente
            throw new System.NotImplementedException();
        }

        public override TEntity Update(TEntity entity)
        {
            // TODO: implemente
            throw new System.NotImplementedException();
        }

        public override void Delete(TEntity entity)
        {
            // TODO: implemente
            throw new System.NotImplementedException();
        }

        // TODO: implemente readonly
        public virtual TDbContext Context { get; set; }

        public DbContext GetDbContext()
        {
            return Context;
        }
    }
}