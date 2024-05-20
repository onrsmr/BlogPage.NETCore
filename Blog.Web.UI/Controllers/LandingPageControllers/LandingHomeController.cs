using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.LandingPageControllers
{
    public class LandingHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
