using Activity1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1.Controllers
{
    public class HiController : Controller
    {
        TrialdbEntities db = new TrialdbEntities();
        [HttpGet]
        // GET: Hi
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string tags)
        {
            Student c = db.Students.Where(x => x.Name.Equals(tags)).SingleOrDefault();
            return View(c);
        }
        public JsonResult getcompanies()
        {
            List<Student> li = db.Students.OrderBy(x => x.Id).ToList();

            return Json(li, JsonRequestBehavior.AllowGet);
        }
    }
}
