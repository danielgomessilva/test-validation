using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var consoles = new ModelWrapper();
            consoles.Deletes = new List<Delete>() { new Delete()};
            consoles.Inserts = new List<Insert>() { new Insert() };
            consoles.Updates = new List<Update>() { new Update() };
            try
            {

                TryValidateModel(consoles);
            }
            catch(Exception e)
            {

            }

            var state = ModelState.IsValid;
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
    }
}