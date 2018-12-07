using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetSecurity.Controllers
{
    [Authorize]
    public class SecretsController : Controller
    {
        // GET: Secrets
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult One() {
            return Content("Secret one!");
        }

        public ActionResult Two() {
            return Content("Secret two!");
        }

        [AllowAnonymous]
        public ActionResult Three() {
            return Content("Secret Three!");
        }
    }
}