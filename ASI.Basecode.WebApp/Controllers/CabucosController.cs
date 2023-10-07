using Microsoft.AspNetCore.Mvc;

namespace ASI.Basecode.WebApp.Controllers
{
    public class CabucosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
