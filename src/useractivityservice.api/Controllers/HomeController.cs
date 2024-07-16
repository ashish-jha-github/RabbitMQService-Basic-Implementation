using Microsoft.AspNetCore.Mvc;

namespace useractivityservice.api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
