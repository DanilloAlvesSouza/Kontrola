namespace KontrolaPoc.Models
{
    public class Chamado
    {
        public int ChamadoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Descricao{ get; set; }
        public string  Diagnostico { get; set; }

        public List<ItemChamado> ItemChamados { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public int ModalidadeId { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public int GravidadeId { get; set; }
        public virtual Gravidade Gravidade { get; set; }

        public int UrgenciaId { get; set; }
        public virtual Urgencia Urgencia { get; set; }

        public int TendenciaId { get; set; }
        public virtual Tendencia Tendencia { get; set; }





    }
}
