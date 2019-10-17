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
            var list = srv.GetAllData(0);
            var sortedList = list;
            int i = 1;
            var placeholder = list[0];


            while(i<list.Length)
            {
                if (list[i].Score > list[i-1].Score)
                {
                    placeholder = list[i - 1];
                    list[i - 1] = list[i];
                    list[i] = placeholder;
                }


                i++;
            }


           



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
            ViewBag.teams = list;

            return View();
        }
    }
}