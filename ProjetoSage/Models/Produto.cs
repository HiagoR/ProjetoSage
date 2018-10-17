using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSage.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
    }
}