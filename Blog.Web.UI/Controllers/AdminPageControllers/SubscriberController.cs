using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class SubscriberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
