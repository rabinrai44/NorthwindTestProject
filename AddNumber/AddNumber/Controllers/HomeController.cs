using AddNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddNumber.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(Test test)
        {
           if (ModelState.IsValid)
            {
                return RedirectToAction("ViewSum");
            }           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewSum(Test sum)
        {
            int getSum = sum.GetSum();
            ViewBag.SumResult = getSum.ToString();
            return View();
        }

        //[HttpPost]
        //public ActionResult Add(Test sum)
        //{
        //    int getSum = sum.GetSum();
        //    ViewBag.SumResult = getSum.ToString();

        //    return View("ViewSum");
        //}
    }
}