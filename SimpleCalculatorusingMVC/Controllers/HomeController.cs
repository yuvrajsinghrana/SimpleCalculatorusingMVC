using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCalculatorusingMVC.Models;

namespace SimpleCalculatorusingMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator model, string cal)
        {
            if (cal=="Add")
            {
                model.Result = model.A + model.B;
                
            }
            if (cal == "Sub")
            {
                model.Result = model.A - model.B;

            }
            if (cal == "Mul")
            {
                model.Result = model.A * model.B;

            }
            if (cal == "Div")
            {
                model.Result = model.A / model.B;

            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a basic calculator created using ASP.Net MVC Framework by Yuvraj Singh Rana";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details :";

            return View();
        }
    }
}