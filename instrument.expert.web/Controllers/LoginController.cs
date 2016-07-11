using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using instrument.expert.dto;
using instrument.expert.web.Helpers;
using Newtonsoft.Json;

namespace instrument.expert.web.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Login()
        {
            if (Request.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(IM_AdminUserDto model)
        {
            if (Request.IsAuthenticated) return RedirectToAction("Index", "Home");
            if (!ModelState.IsValid) return View();
            if (model == null) return View();
            var task = await NetHelper.HttpPost(WebApiUrl.LoginUrl, model, false, RequestDataType.Stream);
            if (!task.IsSuccessStatusCode) return View();
            if (task.StatusCode != HttpStatusCode.OK) return new HttpStatusCodeResult(task.StatusCode);
            var contentString = task.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<TokenDto>(contentString.Result);
            if (token == null) return View();
            FormAuthHelper.SaveCookie(token.CookieName, JsonConvert.SerializeObject(token), token.CookieExprise);
            return RedirectToAction("Index", "Home");
        }

        [AuthCheck]
        public ActionResult SignOut()
        {
            if (Request.IsAuthenticated)
                FormAuthHelper.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}