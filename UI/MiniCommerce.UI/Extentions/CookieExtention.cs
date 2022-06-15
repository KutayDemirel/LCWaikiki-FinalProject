using Microsoft.AspNetCore.Http;
using System;
using System.Net;

namespace MiniCommerce.UI.Extentions
{
    public static class CookieExtension
    {
        public static void SetCookie(this HttpContext context, string key, string value, TimeSpan expires)
        {
            //Cookie myCookie = new Cookie();
            //myCookie.Name = key;
            //myCookie.Value = value;
            //myCookie.Expires = DateTime.Now.Add(expires);
            CookieOptions opt = new CookieOptions
            {
                Expires = DateTime.Now.Add(expires),
                HttpOnly = true
            };

            context.Response.Cookies.Append(key, value, opt);
        }

        public static string GetCookie(this HttpContext context, string key)
        {
            if (context.HasCookie(key))
            {
                var myCookie = context.Request.Cookies[key];
                return myCookie;
            }


            return null;
        }

        public static bool HasCookie(this HttpContext context, string key)
        {
            bool result = context.Request.Cookies.ContainsKey(key);
            return result;
        }

        public static void DeleteCookie(this HttpContext context, string key)
        {
            if (context.HasCookie(key))
                context.Response.Cookies.Delete(key);
        }
    }

}
