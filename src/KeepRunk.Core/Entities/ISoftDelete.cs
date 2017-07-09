namespace KeepRunk.Core.Entities
{
    public interface ISoftDelete
    {
        DeleteState DeleteState { get; set; }
    }
}