using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormCollectionDemo.EDM;

namespace FormCollectionDemo.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            var emplist = from n in dc.tblemployees
                          select n;
            ViewBag.empdata = emplist.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfname"];
            obj.salary = Convert.ToInt32(fc["txtsalary"]);
            obj.mobile = fc["txtmobile"];
            obj.email = fc["txtemail"];
            obj.gender = fc["txtgender"];

            dc.tblemployees.Add(obj);
            dc.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var empobj = from n in dc.tblemployees
                         where n.emp_id == id
                         select n;
            ViewBag.empdata = empobj.FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfname"];
            obj.emp_id = Convert.ToInt32(fc["txtid"]);
            obj.salary = Convert.ToInt32(fc["txtsalary"]);
            obj.mobile = fc["txtmobile"];
            obj.email = fc["txtemail"];
            obj.gender = fc["txtgender"];

            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var empobj = from n in dc.tblemployees
                         where n.emp_id == id
                         select n;
            ViewBag.empdata = empobj.FirstOrDefault();
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult PartialPage()
        {
            return View(dc.tblemployees.ToList());
        }
    }
}