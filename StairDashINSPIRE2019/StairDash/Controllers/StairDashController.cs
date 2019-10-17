using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StairDash.Controllers
{
    public class StairDashController : Controller
    {
        // GET: StairDash
        public ActionResult Index()
        {
            //if (steps == null)
            //{
            //    steps = 0;
            //}
            //else
            //{
            //    ViewBag.steps = steps;
            //}
            

            return View();
        }
    }
}