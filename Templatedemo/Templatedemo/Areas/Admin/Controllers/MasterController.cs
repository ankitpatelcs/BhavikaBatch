using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Templatedemo.Areas.Admin.Controllers
{
    public class MasterController : Controller
    {
        // GET: Admin/Master
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}