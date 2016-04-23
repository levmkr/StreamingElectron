using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            var model = new StartViewModel();
            return View("Index", model);
        }
    }
}
