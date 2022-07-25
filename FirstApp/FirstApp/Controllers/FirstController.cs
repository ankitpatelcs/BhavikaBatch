using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult EmpData()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1,fname="Bhavika",mobile="69873562" });
            li.Add(new Employee { empid=2,fname="Shankar",mobile="69873562" });
            li.Add(new Employee { empid=3,fname="Jenees",mobile="69873562" });
            li.Add(new Employee { empid=4,fname="Piyush",mobile="69873562" });
            return View(li);
        }
    }
}