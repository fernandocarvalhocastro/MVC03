using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Vaga
    {
        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public decimal Salario { get; set; }
        public bool ValeRefeicao { get; set; }
        public string Nivel { get; set; }

    }
}