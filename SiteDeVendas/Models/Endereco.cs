namespace KontrolaPoc.Models
{
    public class Endereco
    {
        public  int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public decimal Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF{ get; set; }

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }
    }
}
