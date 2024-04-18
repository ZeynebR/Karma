using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }
    }
}
