using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionarySite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult MissionIndex()
        {
            return View();
        }

        public ActionResult Mission(string missionName)
        {
            ViewBag.Name = missionName;
            if (missionName == "Virginia Chesapeake")
            {
                ViewBag.President = "Randall F. Weed";
                ViewBag.Address = "1115 Cherokee Road, Portsmouth, VA 23701";
                ViewBag.Language = "English";
                ViewBag.Climate = "Humid";
                ViewBag.Religion = "Southern Baptist";
                ViewBag.Picture = "../../Content/Images/VCMlogo.jpg";
            }
            else if (missionName == "Ghana Cape Coast")
            {
                ViewBag.President = "Richard S. Stevenson";
                ViewBag.Address = "PMB CC 1385, Cape Coast, Ghana";
                ViewBag.Language = "English, Ethnic languages";
                ViewBag.Climate = "Hot";
                ViewBag.Religion = "Christianity";
                ViewBag.Picture = "../../Content/Images/GhanaianFlag.png";
            }
            else if (missionName == "Jamaica Kingston")
            {
                ViewBag.President = "Scott C. Pearson";
                ViewBag.Address = "4 Garelli Ave, Kingston 10, Jamaica WI";
                ViewBag.Language = "English";
                ViewBag.Climate = "Humid";
                ViewBag.Religion = "Christianity";
                ViewBag.Picture = "../../Content/Images/KJMlogo.jpg";
            }
            return View();
        }
        public ActionResult Directions(string missionName)
        {
            ViewBag.Name = missionName;
            if (missionName == "Virginia Chesapeake")
            {
                ViewBag.Address = "1115 Cherokee Road, Portsmouth, VA 23701";
            }
            else if (missionName == "Ghana Cape Coast")
            {
                ViewBag.Address = "PMB CC 1385, Cape Coast, Ghana";
            }
            else if (missionName == "Jamaica Kingston")
            {
                ViewBag.Address = "4 Garelli Ave, Kingston 10, Jamaica WI";
            }
            return View();
        }
    }
}