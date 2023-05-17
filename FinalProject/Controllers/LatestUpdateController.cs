using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    [Authorize(Roles = "Admin,Teacher,Student")]
    public class LatestUpdateController : Controller
    {
        // GET: LatestUpdate
        public ActionResult Index()
        {
            return View();
        }
    }
}