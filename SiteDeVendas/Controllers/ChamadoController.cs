using KontrolaPoc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KontrolaPoc.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepository _chamadoReposity;

        public ChamadoController(IChamadoRepository chamadoReposity)
        {
            _chamadoReposity = chamadoReposity;
        }

        public IActionResult List()
        {
            var chamados = _chamadoReposity.Chamados;
            return View(chamados);
        }
    }
}
