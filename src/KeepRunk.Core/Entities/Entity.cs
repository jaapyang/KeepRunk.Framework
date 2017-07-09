namespace KeepRunk.Core.Entities
{
    public class Entity<T> : IEntity
        where T : struct
    {
        public virtual T Id { get; set; }
    }

    public class Entity : Entity<int>
    {
        public override int Id { get; set; }
    }
}