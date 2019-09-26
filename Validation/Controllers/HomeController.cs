using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var consoles = new List<GameConsole>();
            consoles.Add(new Delete());
            consoles.Add(new Insert());
            consoles.Add(new Update());

            ValidateListModelState(consoles);

            return View(consoles);
        }

        private void ValidateListModelState<T>(List<T> consoles) where T : GameConsole
        {
            var dictinory = new ModelStateDictionary();

            for (int entityPosition = 0; entityPosition < consoles.Count; entityPosition++)
            {
                TryValidateModel(consoles[entityPosition]);

                for (int i = 0; i < ModelState.Keys.Count; i++)
                    dictinory.Add($"[{entityPosition}].{ModelState.Keys.ToList()[i]}", ModelState.Values.ToList()[i]);

                var entityStateDictionary = consoles[entityPosition].State;

                entityStateDictionary.ToList().ForEach(x =>
                {
                    dictinory.AddModelError($"[{entityPosition}].{x.Key}", x.Value);
                });

                ModelState.Clear();
            }

            for (int i = 0; i < dictinory.Keys.Count; i++)
                ModelState.Add(dictinory.Keys.ToList()[i], dictinory.Values.ToList()[i]);
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