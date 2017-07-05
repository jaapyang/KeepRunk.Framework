namespace KeepRunk.Application.Core
{
    /// <summary>
    /// 会话信息上下文
    /// </summary>
    public class MessageContext
    {
        private readonly long _userId;

        public MessageContext(long userId)
        {
            _userId = userId;
        }

        public long UserId
        {
            get
            {
                return _userId; 
            }
        }
    }
}