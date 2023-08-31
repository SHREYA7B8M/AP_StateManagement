using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        public System.Web.Mvc.ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public System.Web.Mvc.ActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        

        [System.Web.Mvc.HttpPost]
        public ViewResult ViewDataSubmit()
        {
            ViewData["name"] = Request.Form["name"];
            ViewData["address"] = Request.Form["address"];
            ViewData["class"] = Request.Form["class"];
            ViewData["year"] = Request.Form["year"];

            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ViewResult ViewBagSubmit()
        {
            ViewBag.name = Request.Form["name"];
            ViewBag.address = Request.Form["address"];
            ViewBag.sclass = Request.Form["sclass"];
            ViewBag.year = Request.Form["year"];

            return View();
        }

        //[System.Web.Mvc.HttpPost]
        public System.Web.Mvc.ActionResult GetTempDataSubmit()
        {
            TempData["name"] = Request.Form["name"].ToString();
            TempData["address"] = Request.Form["address"].ToString();
            TempData["class"] = Request.Form["class"].ToString();


            TempData["year"] = Request.Form["year"].ToString();

            return RedirectToAction("TempDataSubmit");
        }

        public ViewResult TempDataSubmit
        {
            get
            {
                var model = TempData["name"];
                return View();
            }
        }
    }

    internal class ErrorViewModel : IView
    {
        public object RequestId { get; set; }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}