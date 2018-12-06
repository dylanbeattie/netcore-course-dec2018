using AspNetMvcDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetMvcDemo.WebApp.Controllers {
    public class AnimalsController : Controller {
        public IActionResult Index() {
            using (var db = new AnimalDbContext()) {
                return View(db.Animals.ToList());
            }
        }
    }
}
