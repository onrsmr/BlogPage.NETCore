using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
