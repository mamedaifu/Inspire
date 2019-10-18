using StairDash.StairDataServiceReference;
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

             percent = (((float)steps / (float)mileStone) * 100.0f);
            percent = (float)Math.Round(percent, 1);
            ViewBag.stepPercent = percent;

            if (percent > 100)
            {
                percent = 100;
            }

            ViewBag.gaugePercent = Math.Round(percent / 5.0) * 5;
            ViewBag.gaugeDisplayPercent = percent;




            ViewBag.mileStone = mileStone;
            ViewBag.teams = list;

            return View();
        }


        public ActionResult TeamView()
        {

            ViewBag.teams = list;

            return View();
        }


        private StairDataServiceReference.ServiceTeamObj[] SortTeams(ServiceTeamObj[] list )
        {
            var newlist = list;
            int i = 1;
            int n = 0;
            var placeholder = list[0];

            var loop = true;
            while (loop)
            {
                while (n < list.Length)
                {
                    while (i < list.Length)
                    {
                        if (list[i].Score > list[i - 1].Score)
                        {
                            placeholder = list[i - 1];
                            list[i - 1] = list[i];
                            list[i] = placeholder;
                        }

                        i++;
                    }

                    n++;
                }

                if(list.Max == list[0])
                {

                }

            }

            return list;
        }
    }
}