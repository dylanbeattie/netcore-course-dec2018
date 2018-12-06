using EFDemo1.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace EFDemo1.WebApplication.Controllers {
    public class AnimalsController : Controller {

        public IActionResult Index() {
            using(var db = new AnimalDbContext()) {
                var model = db.Animals;
                return View(model);
            }
        }
    }
}
