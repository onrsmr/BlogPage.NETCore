using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.LandingPageControllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
