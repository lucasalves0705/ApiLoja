using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProdutos.Data
{
    public class Produto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Informar um nome")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Nome do produto deve ter entre 3 e 80 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Informar um valor")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Valor deve ser maior que 0")]
        public float valor { get; set; }

        [Required(ErrorMessage = "Informar um status")]
        public bool status { get; set; }
    }
}
