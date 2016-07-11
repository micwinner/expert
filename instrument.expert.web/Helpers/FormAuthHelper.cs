using System;
using System.Web;
using System.Web.Security;

namespace instrument.expert.web.Helpers
{
    public class FormAuthHelper
    {
        public static void SaveCookie(string uName, string uData, int expiration)
        {
            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uData))
                throw new Exception("User data is null!");
            FormsAuthentication.SetAuthCookie(uName, true);

            var ticket = new FormsAuthenticationTicket(
                1,
                uName,
                DateTime.Now,
                DateTime.Now.Add(TimeSpan.FromMinutes(expiration)),
                true,
                uData,
                FormsAuthentication.FormsCookiePath
                );

            var ticketStr = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, ticketStr)
            {
                HttpOnly = true,
                Secure = FormsAuthentication.RequireSSL,
                Domain = FormsAuthentication.CookieDomain,
                Path = FormsAuthentication.FormsCookiePath
            };
            if (expiration > 0)
                cookie.Expires = DateTime.Now.AddMinutes(expiration);

            HttpContext.Current.Response.Cookies.Remove(cookie.Name);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static string GetCookie()
        {
            var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket authTicket = null;
            try
            {
                if (authCookie != null)
                    authTicket = FormsAuthentication.Decrypt(authCookie.Value);
            }
            catch (Exception)
            {
                return null;
            }
            return authTicket != null ? authTicket.UserData : null;
        }

        public static void SignOut()
        {
            FormsAuthentication.SignOut();
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, string.Empty)
            {
                Expires = DateTime.Now.AddYears(-3)
            };
            HttpContext.Current.Response.SetCookie(cookie);
        }
    }
}