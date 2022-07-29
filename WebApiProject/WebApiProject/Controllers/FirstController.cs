using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApiProject.EDM;

namespace WebApiProject.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public async Task<ActionResult> Index()
        {
            IEnumerable<tblemployee> emplist = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = await client.GetAsync("api/Default");

                //To store result of web api response.   
                //If success received   
                if (responseTask.IsSuccessStatusCode)
                {
                    var readTask = await responseTask.Content.ReadAsAsync<IList<tblemployee>>();
                    emplist = readTask;
                }
                else
                {
                    //Error response received   
                    emplist = Enumerable.Empty<tblemployee>();
                    ModelState.AddModelError(string.Empty, "Error.!");
                }
            }
            return View(emplist);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(tblemployee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                //HTTP POST
                var response = await client.PostAsJsonAsync<tblemployee>("api/Default", obj);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Error.!");
            return View(obj);
        }

        public async Task<ActionResult> Edit(int id)
        {
            tblemployee empobj = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                var responseTask = await client.GetAsync($"api/Default/{id}");

                //If success received   
                if (responseTask.IsSuccessStatusCode)
                {
                    var readTask = await responseTask.Content.ReadAsAsync<tblemployee>();
                    empobj = readTask;
                }
                else
                {
                    //Error response received   
                    empobj = null;
                    ModelState.AddModelError(string.Empty, "Error.!");
                }
            }
            return View(empobj);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(tblemployee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                //HTTP POST
                var response = await client.PutAsJsonAsync<tblemployee>($"api/Default/{obj.emp_id}", obj);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Error.!");
            return View(obj);
        }
        
        public async Task<ActionResult> Delete(int id)
        {
            tblemployee empobj = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                var responseTask = await client.GetAsync($"api/Default/{id}");

                //If success received   
                if (responseTask.IsSuccessStatusCode)
                {
                    var readTask = await responseTask.Content.ReadAsAsync<tblemployee>();
                    empobj = readTask;
                }
                else
                {
                    //Error response received   
                    empobj = null;
                    ModelState.AddModelError(string.Empty, "Error.!");
                }
            }
            return View(empobj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteRec(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44377/");

                //HTTP POST
                var response = await client.DeleteAsync($"api/Default/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Error.!");
            return View();
        }
    }
}