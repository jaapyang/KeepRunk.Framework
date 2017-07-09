using System;
using System.Configuration;

namespace KeepRunk.Core.Web
{
    public sealed class ConfigHelper
    {
        public static string Get(string key)
        {
            try
            {
                var cacheTag = "appconfig_" + key;
                return CacheHelper.Get(cacheTag, () =>
                {
                    var result = ConfigurationManager.AppSettings[key];
                    return result;
                });
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}