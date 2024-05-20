using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
