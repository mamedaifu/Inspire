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
        public ActionResult Index(int? steps)
        {
            StairDataServiceReference.ServiceClient srv = new StairDataServiceReference.ServiceClient();

            

            int mileStone = 8000;
            float percent;

            if (steps == null)
            {
                steps = 0;
                ViewBag.steps = steps;
            }
            else
            {
                ViewBag.steps = steps;
            }

            ViewBag.stepPercent = percent = (((float)steps / (float)mileStone) * 100.0f);
            ViewBag.gaugePercent = Math.Round(percent / 5.0) * 5;
            ViewBag.mileStone = mileStone;
            ViewBag.teams = srv.GetAllData(0);

            return View();
        }
    }
}