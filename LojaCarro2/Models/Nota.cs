using LojaCarro2.Models;
using System;

namespace LojaCarro2.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public decimal ValorVenda { get; set; }

        public Cliente Cliente { get; set; } 
        public Vendedor Vendedor { get; set; } 
        public Carro Carro { get; set; } 
    }
}