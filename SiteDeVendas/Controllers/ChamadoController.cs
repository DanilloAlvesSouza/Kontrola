using Microsoft.AspNetCore.Mvc;

namespace KontrolaPoc.Controllers
{
    public class ChamadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
