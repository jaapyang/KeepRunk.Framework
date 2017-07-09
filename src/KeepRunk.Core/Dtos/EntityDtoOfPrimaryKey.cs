using System;

namespace KeepRunk.Core.Dtos
{
    [Serializable]
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }

        public EntityDto() { }

        public EntityDto(TPrimaryKey id)
        {
            Id = id;
        }
    }
}