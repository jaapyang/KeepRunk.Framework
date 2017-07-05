namespace KeepRunk.Application.Core
{
    public abstract class ApplcationServiceBase<TInput, TOutput> : IApplicationService<TInput, TOutput>
        where TInput : IApplicationInput
        where TOutput : IApplicationOutput
    {
        protected MessageContext MessageContext { get; private set; }

        public TOutput HandlerService(TInput input)
        {
            MessageContext = new MessageContext(input.UserId);

            return ProcessService(input);
        }

        protected abstract TOutput ProcessService(TInput input);
    }
}