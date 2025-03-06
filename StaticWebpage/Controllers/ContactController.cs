using Microsoft.AspNetCore.Mvc;

namespace StaticWebpage.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Contact/Index.cshtml");
        }
    }
}
