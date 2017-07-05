namespace KeepRunk.Application.Core
{
    public interface IApplicationInput
    {
        long UserId { get; set; }
        string UserName { get; set; }
    }
}