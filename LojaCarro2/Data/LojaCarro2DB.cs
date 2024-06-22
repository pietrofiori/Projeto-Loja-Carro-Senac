
using LojaCarro2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LojaCarro2.Data
{
    public class LojaCarroDB2 : DbContext
    {
        public LojaCarroDB2(DbContextOptions<LojaCarroDB2> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .Property(c => c.Preco)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Nota>()
                .Property(n => n.ValorVenda)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Salario)
                .HasColumnType("decimal(18,2)");
        }

    }
}
