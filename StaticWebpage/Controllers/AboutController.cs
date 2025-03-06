using Microsoft.AspNetCore.Mvc;

namespace StaticWebpage.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/About/Index.cshtml");
        }
    }
}
