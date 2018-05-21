using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspPractice.Models;
using aspPractice.ViewModels;

namespace aspPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Resources()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Subjects()
        {
            var subject = new Models.Subject() { Name = "Algebra", Difficulty = "Easy" };

            var problem = new List<Problem>
            {
                new Problem { Id = 0001},
                new Problem { Id = 0002}
            };

            var viewModel = new SubjectsViewModel
            {
                Subject = subject,
                Problem = problem

            };
            return View(viewModel);
        }


        public ActionResult Users()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /*enables atribute routing in routeconfig.cs
        regex = regular expression
        see constraints for more info*/

        [Route("Home/Subjects/{problem}/{num}")]
        public ActionResult ByProblem(string problem, int num)
        {
            ViewBag.Message = problem + " " + num;
            return View();

        }
    }
}