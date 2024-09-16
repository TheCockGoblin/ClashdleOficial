using Microsoft.AspNetCore.Mvc;

namespace clashclash.Controllers
{
    public class DailyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
