using KontrolaPoc.Models;

namespace KontrolaPoc.ViewModels
{
    public class ChamadosListViewModel
    {
        public IEnumerable<Chamado> Chamados { get; set; }
        public string StatusAtual { get; set; } 
       

    }
}
