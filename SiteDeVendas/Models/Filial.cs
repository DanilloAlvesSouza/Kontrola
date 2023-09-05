namespace KontrolaPoc.Models
{
    public class Filial
    {
        public int FilialId { get; set; }
        public string Descricao { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
