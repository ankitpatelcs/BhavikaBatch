using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.EDM;

namespace AjaxDemo.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.tblemployees.ToList(),JsonRequestBehavior.AllowGet);
        }

        void fillstates()
        {
            var states = from s in dc.tblstates
                         select new SelectListItem
                         {
                             Text=s.state_name,
                             Value=s.state_id.ToString()
                         };
            ViewBag.states = states.ToList();
        }

        public ActionResult Create()
        {
            fillstates();
            return View();
        }
        [HttpPost]
        public string Create(tblemployee obj)
        {
            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return "Insert Success.!";
        }

        public ActionResult Edit(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        public string Edit(tblemployee obj)
        {
            dc.Entry(obj).State=System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return "Update Success.!";
        }

        public ActionResult Details(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        
        public string Delete(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return "Record Deleted.";
        }

        public JsonResult GetCitiesByStateId(int id)
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.tblcities.Where(c=>c.state_id==id).ToList(),JsonRequestBehavior.AllowGet);
        }

    }
}