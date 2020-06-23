using Holtz_PDV_EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//get-help entityFrameworkCore (View->Other Windows->Package Mananger Console)
namespace Holtz_PDV_EFCore.WebAPI.Data
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=BD_Holtz_PDV_2;Data Source=HENRIQUE-NOT\SQL2014");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Empresa
            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => new { e.EmpCod});
            });
            //Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => new { e.UsuCod });
            });
            //UsuarioEmpresas
            modelBuilder.Entity<UsuarioEmpresas>(entity =>
            {
                entity.HasKey(e => new { e.UsuCod, e.EmpCod });
            });
            //Filial
            modelBuilder.Entity<Filial>(entity => 
            {
                entity.HasKey(e => new { e.EmpCod, e.FilCod });
            });
            //Pessoa
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => new { e.EmpCod, e.PesCod });
            });
            //Produto
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => new { e.EmpCod, e.ProCod });
            });
        }
    }
}
