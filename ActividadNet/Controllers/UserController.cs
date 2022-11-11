using Microsoft.AspNetCore.Mvc;

namespace ActividadNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
