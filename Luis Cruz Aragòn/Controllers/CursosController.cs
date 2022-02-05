using Microsoft.AspNetCore.Mvc;

namespace Luis_Cruz_Aragòn.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
