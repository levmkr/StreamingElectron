using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApp.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
