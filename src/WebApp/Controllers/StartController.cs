using System;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult GetPartcipant(Participant participant)
        {
            // check in the db if participant exists
            // if yes: show new form where user enters email and saves it to the db
            throw new NotImplementedException();
        }
    }
}
