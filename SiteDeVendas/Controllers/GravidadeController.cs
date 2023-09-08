using KontrolaPoc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KontrolaPoc.Controllers
{
    public class GravidadeController : Controller
    {
        private readonly IGravidadeRepository _gravidadeRepository;

        public GravidadeController(IGravidadeRepository gravidadeRepository)
        {
            _gravidadeRepository = gravidadeRepository;
        }

        public IActionResult List()
        {
            var gravidades = _gravidadeRepository.Gravidades;
            return View(gravidades);
        }
    }
}
