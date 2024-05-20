using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.LandingPageControllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
