using Microsoft.AspNetCore.Mvc;
using System;

namespace prviProjekat_2_.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
