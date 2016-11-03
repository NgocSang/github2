using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThemUser.Models;

namespace ThemUser.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var message = new MessageModel();
            message.Welcome = "Hello ASP.NET";
            return View(message);
        }

    }
}
