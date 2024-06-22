using LojaCarro2.Models;
using System;
using System.Collections.Generic;

namespace LojaCarro2.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        public ICollection<Nota> Notas { get; set; }
    }
}