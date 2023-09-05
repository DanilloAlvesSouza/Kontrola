using System.Security.Principal;

namespace KontrolaPoc.Models
{
    public class Equipamento
    {
        public int EquipamentoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Potencia { get; set; }

        public List<ItemChamado> itemChamados { get; set; }

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }


    }
}
