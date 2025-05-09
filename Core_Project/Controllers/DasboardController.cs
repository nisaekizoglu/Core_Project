using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Sayfası";
            return View();
        }
    }
}
