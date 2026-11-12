using Microsoft.AspNetCore.Mvc;

namespace GabrielBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
