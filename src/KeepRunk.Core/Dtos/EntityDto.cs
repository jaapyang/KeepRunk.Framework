namespace KeepRunk.Core.Dtos
{
    public class EntityDto : EntityDto<int>, IEntityDto
    {
        public EntityDto() { }

        public EntityDto(int id) : base(id) { }
    }
}