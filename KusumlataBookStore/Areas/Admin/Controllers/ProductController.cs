using Microsoft.AspNetCore.Mvc;

namespace KusumlataBookStore.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
