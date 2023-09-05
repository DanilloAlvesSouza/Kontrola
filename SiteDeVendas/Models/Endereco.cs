﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KontrolaPoc.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public  int EnderecoId { get; set; }
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Column(TypeName ="decimal(8)")]
        public decimal Cep { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Cidade { get; set; }

        [StringLength(2)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string UF{ get; set; }

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }
    }
}
