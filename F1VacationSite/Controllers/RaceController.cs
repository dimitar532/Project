using Microsoft.AspNetCore.Mvc;

namespace F1VacationSite.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
