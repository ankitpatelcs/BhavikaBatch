using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatatablesAndWebGrid.EDM;

namespace DatatablesAndWebGrid.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }
        public ActionResult Index2()
        {
            return View(dc.tblemployees.ToList());
        }
    }
}