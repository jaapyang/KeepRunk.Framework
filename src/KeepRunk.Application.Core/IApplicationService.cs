namespace KeepRunk.Application.Core
{
    public interface IApplicationService<in TInput, out TOutput> 
        where TInput : IApplicationInput
        where TOutput:IApplicationOutput
    {
        TOutput HandlerService(TInput input);
    }
}