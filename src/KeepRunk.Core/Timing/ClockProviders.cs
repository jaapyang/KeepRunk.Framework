namespace KeepRunk.Core.Timing
{
    public static class ClockProviders
    {
        static ClockProviders()
        {
            Unspecified =  new UnspecifiedClockProvider();
            Local = new LocalClockProvider();
            Utc = new UtcClockProvider();
        }
        public static UnspecifiedClockProvider Unspecified { get; private set; }

        public static LocalClockProvider Local { get; private set; } 

        public static UtcClockProvider Utc { get; private set; } 
    }
}