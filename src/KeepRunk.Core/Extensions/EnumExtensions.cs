using System;

namespace KeepRunk.Core.Extensions
{
    public static class EnumExtensions
    {
        public static int ToInt(this Enum t)
        {
            return Convert.ToInt32(t);
        }
    }
}
