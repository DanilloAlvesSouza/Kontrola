using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KontrolaPoc.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="O nome do cliente deve ser informado")]
        [Display(Name ="Nome do Cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="CNPJ do cliente deve ser informado")]
        [Display(Name="CNPJ")]
        public string Cnpj { get; set; }

        public List<Filial> Filiais { get; set; }
    }
}
