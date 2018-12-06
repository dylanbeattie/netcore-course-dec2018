using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFDemo1.WebApplication.Models;

namespace EFDemo1.WebApplication.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Hello(string salutation = "Hi", string message = "Look at the stars once in a while") {
            var generator = new GreetingGenerator(salutation);
            var model = new HelloViewModel();
            model.PersonalisedGreetings = generator.GenerateGreetings("Ruth", "Josie", "Mark", "Hernando");
            model.MessageOfTheDay = message;
            return View(model);
        }
        

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
