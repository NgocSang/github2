using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThemUser.Areas.Admin.Code;
using ThemUser.Areas.Admin.Models;

namespace ThemUser.Areas.Admin.Controllers
{
    public class SignupController : Controller
    {
        //
        // GET: /Admin/Signup/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SignupModel model)
        {
            var result = new AccountModel().Signup(model.UserName, model.Password);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { Username = model.UserName });
                return RedirectToAction("index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập đã có người dùng");
            }
            return View(model);
        }
    }
}
