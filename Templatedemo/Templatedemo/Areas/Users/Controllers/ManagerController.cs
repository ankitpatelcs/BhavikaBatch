using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Templatedemo.Areas.Users.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Users/Manager
        public ActionResult Homepage()
        {
            return View();
        }
    }
}