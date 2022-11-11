using Microsoft.AspNetCore.Mvc;

namespace ActividadNet.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
