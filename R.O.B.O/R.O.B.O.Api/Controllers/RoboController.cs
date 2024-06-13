using Microsoft.AspNetCore.Mvc;

namespace R.O.B.O.Api.Controllers
{
    public class RoboController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
