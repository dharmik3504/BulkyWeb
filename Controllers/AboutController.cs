using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
