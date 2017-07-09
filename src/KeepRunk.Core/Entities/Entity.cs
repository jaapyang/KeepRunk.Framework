using System;
using System.ComponentModel.DataAnnotations;

namespace KeepRunk.Core.Entities
{
    [Serializable]
    public abstract class Entity : Entity<int>
    {
        [Key]
        public override int Id { get; set; }
    }
}