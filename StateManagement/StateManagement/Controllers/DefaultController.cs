using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string username = fc["txtuname"];
            string password = fc["txtpassword"];

            if (username == "bhavika" && password == "123")
            {
                HttpCookie couname = new HttpCookie("uname");
                couname.Value = username;
                couname.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(couname);

                HttpCookie copass = new HttpCookie("password");
                copass.Value = password;
                copass.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(copass);
            }

            return View();
        }

        public ActionResult qstring()
        {
            return View();
        }
        public ActionResult GetQ(string name)
        {
            ViewBag.data = name;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string username = fc["txtuname"];
            string password = fc["txtpassword"];

            if (username == "bhavika" && password == "123")
            {
                Session["uname"] = username;
                Session.Timeout = 30;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Username or Password";
            }
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult Svar()
        {
            ViewBag.message = "text from ViewBag";
            ViewData["msg"] = "text from ViewData";
            TempData["data"] = "text from TempData";
            return View();
        }

        public ActionResult Second()
        {
            return View();
        }
    }
}