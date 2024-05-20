using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.LandingPageControllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
