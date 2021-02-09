using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeusProdutos.Data
{
    public class Usuario
    {
        public int id { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 80 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "E-mail deve ser preenchido!")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido")]
        //[Remote("EmailUnico", "Usuario", ErrorMessage = "E-mail já cadastrado")]
        public string email { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada.")]
        public string senha { get; set; }
    }
}
