using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProdutos.Data
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float valor { get; set; }
        public bool status { get; set; }
    }
}
