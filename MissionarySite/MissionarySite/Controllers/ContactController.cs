using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionarySite.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Subject()
        {
            List<SelectListItem> subjects = new List<SelectListItem>();
            subjects.Add(new SelectListItem { Text = "Question", Value = "0", Selected = true });
            subjects.Add(new SelectListItem { Text = "Answer", Value = "1" });
            subjects.Add(new SelectListItem { Text = "Comment", Value = "2"});
            ViewBag.Subjects = subjects;
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}