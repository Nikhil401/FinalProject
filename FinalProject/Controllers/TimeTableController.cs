using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    
    public class TimeTableController : Controller
    {
        // GET: TimeTable
        [Authorize(Roles = "Admin,Teacher,Student")]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Home() 
        { 
            return View();
        }
    }
}