using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorControls.EDM;

namespace RazorControls.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }

        void fillcity()
        {
            var data = from c in dc.tblcities
                       select new SelectListItem
                       {
                           Value = c.city_id.ToString(),
                           Text = c.city_name
                       };
            ViewBag.cities = data.ToList();
        }

        public ActionResult Create()
        {
            fillcity();
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj, FormCollection fc, HttpPostedFileBase file)
        {
            bool Reading = Convert.ToBoolean(fc["Reading"].Split(',')[0]);
            bool Playing = Convert.ToBoolean(fc["Playing"].Split(',')[0]);
            bool Driving = Convert.ToBoolean(fc["Driving"].Split(',')[0]);
            string hoby = "";

            if (Reading)
            {
                hoby += "Reading,";
            }
            if (Playing)
            {
                hoby += "Playing,";
            }
            if (Driving)
            {
                hoby += "Driving,";
            }
            obj.hobbies = hoby;

            if (file!=null)
            {
                string filename = Path.GetFileName(file.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/Images"),filename);
                file.SaveAs(fullpath);
                obj.profileimg = filename;
            }

            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            fillcity();
            return View();
        }
    }
}