using GabrielBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GabrielBookWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
