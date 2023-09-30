using KontrolaPoc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KontrolaPoc.Controllers
{
    public class EquipamentoController : Controller
    {
        private readonly IEquipamentoRepository _equipamentoRepository;

        public EquipamentoController(IEquipamentoRepository equipamentoRepository)
        {
            _equipamentoRepository = equipamentoRepository;
        }

        public IActionResult List()
        {
            ViewBag.OpcaoMenu = 3;
            var Equipamentos = _equipamentoRepository.Equipamentos;
            return View(Equipamentos);
        }
    }
}
