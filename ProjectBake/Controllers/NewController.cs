using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectBake.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return Content("This a Bakery Project......!!!!");
        }

        public IActionResult Action()
        {
            return Content("Hello...");
        }

        public IActionResult GetAction()
        {
            return Content("Welcome..........");
        }
    }
}
