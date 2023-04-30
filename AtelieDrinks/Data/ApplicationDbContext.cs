using AtelieDrinks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AtelieDrinks.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Base_alcoolica> Base_Alcoolica { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Custo_deslocamento> Custo_Deslocamento { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Custo_operacional> Custo_operacional { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Deposito> Deposito { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Drinks> Drinks { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Ficha_tecnica> Ficha_tecnica { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Historico> Historico { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Insumos> Insumos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Marca> Marca { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Orcamento> Orcamento { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base_alcoolica>()
                .HasNoKey();

            modelBuilder.Entity<Custo_deslocamento>()
                .HasNoKey();

            modelBuilder.Entity<Custo_operacional>()
                .HasNoKey();
            modelBuilder.Entity<Deposito>()
                .HasNoKey();

            modelBuilder.Entity<Drinks>()
                .HasNoKey();

            modelBuilder.Entity<Ficha_tecnica>()
                .HasNoKey();

            modelBuilder.Entity<Historico>()
                .HasNoKey();

            modelBuilder.Entity<Insumos>()
                .HasNoKey();

            modelBuilder.Entity<Marca>()
                .HasNoKey();

            modelBuilder.Entity<Orcamento>()
                .HasNoKey();
        }
    }
}