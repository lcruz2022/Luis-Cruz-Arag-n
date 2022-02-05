using Microsoft.AspNetCore.Mvc;

namespace Luis_Cruz_Aragòn.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult UNI()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View("Test");
        }
    }
}
