using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.LandingPageControllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
