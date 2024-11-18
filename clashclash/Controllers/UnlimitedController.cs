using Microsoft.AspNetCore.Mvc;

namespace clashclash.Controllers
{
    public class UnlimitedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
