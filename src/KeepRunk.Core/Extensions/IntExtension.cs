using System;

namespace KeepRunk.Core.Extensions
{
    public static class IntExtension
    {
        public static double ToDouble(this int i)
        {
            return Convert.ToDouble(i);
        }

        public static decimal ToDecimal(this int i)
        {
            return Convert.ToDecimal(i);
        }
    }
}