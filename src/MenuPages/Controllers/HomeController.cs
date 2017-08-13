using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MenuPages.Controllers
{
    public class HomeController : Controller
    {
        /*
         * ACTION TO RETURN HOMEPAGE
         */
        public IActionResult Index()
        {
            ViewData["description"] = "Welcome to Camposha.info. Alongside ProgrammingWizards TV we provide easy to understand Programming guides in various languages.";

            return View();
        }

        /*
         * ACTION TO RETURN ABOUT US PAGE 
         */
        public IActionResult About()
        {
            ViewData["description"] = "Camposha.info is a programming tutorials website.Alongside ProgrammingWizards TV, they provide easy to understand programming guides in different programming languages.";

            return View();
        }

        /*
         * ACTION TO RETURN CONTACT US PAGE
         */
        public IActionResult Contact()
        {
            ViewData["descritipm"] = "You can contact camposha.info at our website or via our programmingwizards tv youtube channel.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
