using System;
using System.Web;

namespace KeepRunk.Core.Web
{
    public enum EnmCookieKeys
    {
        /// <summary>
        /// 用户名
        /// </summary>
        UserName,
        /// <summary>
        /// 用户Id
        /// </summary>
        UserCode,
        SessionId,
        /// <summary>
        /// 用户密码
        /// </summary>
        Password
    }

    /// <summary>
    /// Cookie辅助类
    /// </summary>
    public class CookieHelper
    {
        /// <summary>
        /// 清除指定Cookie
        /// </summary>
        /// <param name="cookiename">cookiename</param>
        private static void ClearCookie(string cookiename)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
            if (cookie == null) return;
            cookie.Expires = DateTime.Now.AddYears(-3);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 清除指定Cookie
        /// </summary>
        /// <param name="keys">cookiename</param>
        public static void ClearCookie(EnmCookieKeys keys)
        {
            ClearCookie(keys.ToString());
        }

        /// <summary>
        /// 获取指定Cookie值
        /// </summary>
        /// <param name="cookiename">cookiename</param>
        /// <returns></returns>
        private static string GetCookieValue(string cookiename)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
            string str = string.Empty;
            if (cookie != null)
            {
                str = cookie.Value;
            }
            return str;
        }

        /// <summary>
        /// 获取指定Cookie值
        /// </summary>
        /// <param name="key">cookiename</param>
        /// <returns></returns>
        public static string GetCookieValue(EnmCookieKeys key)
        {
            return GetCookieValue(key.ToString());
        }

        /// <summary>
        /// 添加一个Cookie（24小时过期）
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cookievalue"></param>
        public static void SetCookie(EnmCookieKeys key, string cookievalue)
        {
            SetCookie(key, cookievalue, DateTime.Now.AddDays(1.0));
        }

        /// <summary>
        /// 添加一个Cookie
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cookievalue">cookie值</param>
        /// <param name="expires">过期时间 DateTime</param>
        public static void SetCookie(EnmCookieKeys key, string cookievalue, DateTime expires)
        {
            SetCookie(key.ToString(), cookievalue, expires);
        }

        /// <summary>
        /// 添加一个Cookie
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cookievalue">cookie值</param>
        /// <param name="expires">过期时间 DateTime</param>
        private static void SetCookie(string key, string cookievalue, DateTime expires)
        {
            var cookie = new HttpCookie(key)
            {
                Value = cookievalue,
                Expires = expires
            };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}