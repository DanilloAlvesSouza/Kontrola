using KontrolaPoc.Repositories.Interfaces;
using KontrolaPoc.ViewModels;
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
            ViewBag.OpcaoMenu = 2;
            //var chamados = _chamadoReposity.Chamados;
            //return View(chamados);

            var chamadosListViewModel = new ChamadosListViewModel();
            chamadosListViewModel.Chamados = _chamadoReposity.Chamados;
            chamadosListViewModel.StatusAtual = "Status Atual";

            return View(chamadosListViewModel);
            
        }
    }
}
