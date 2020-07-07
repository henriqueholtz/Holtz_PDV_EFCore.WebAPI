using EFCore.Domain;
using EFCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//get-help entityFrameworkCore (View->Other Windows->Package Mananger Console)

namespace EFCore.Repo
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options) : base(options){}
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //agr faz pelo appsettings.json e Startup.cs
            //optionsBuilder.UseSqlServer(@"Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=BD_Holtz_PDV_2;Data Source=HENRIQUE-NOT\SQL2014");
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Company
            modelBuilder.Entity<Empresa>(entity =>
            {
                //entity.HasKey(e => new { e.EmpCod});//Define PK
                entity.Property(e => e.EmpCod).ValueGeneratedNever(); //Remove Identity
                //entity.Property(e => e.EmpCpfCnpj).HasColumnType("VARCHAR(18)");//Define Type and size
                //entity.Property(e => e.EmpCod).HasMaxLength(8); //Define Type and size
                entity.Property(empSts => empSts.EmpSts).HasColumnType(Type.Status_AtivoInativo.Type);
            });
            //User
            modelBuilder.Entity<Usuario>(entity =>
            {
                //entity.HasKey(e => new { e.UsuCod });//Define PK
                entity.Property(e => e.UsuCod).ValueGeneratedNever();//Remove Identity
                entity.Property(usuSts => usuSts.UsuSts).HasColumnType(Type.Status_AtivoInativo.Type);
            });
            //User - Companies
            modelBuilder.Entity<UsuarioEmpresas>(entity =>
            {
                //entity.HasKey(e => new { e.UsuCod, e.EmpCod });//Define PK
                entity.Property(e => e.UsuCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
            });
            //Filial
            modelBuilder.Entity<Filial>(entity => 
            {
                //entity.HasKey(e => new { e.EmpCod, e.FilCod });//Define PK
                entity.Property(e => e.FilCod).ValueGeneratedNever();//Remove Identity
            });
            //Pessoa
            modelBuilder.Entity<Pessoa>(entity =>
            {
                //entity.HasKey(e => new { e.EmpCod, e.PesCod });//Define PK
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.PesCod).ValueGeneratedNever();//Remove Identity
                entity.Property(pesSts => pesSts.PesSts).HasColumnType(Type.Status_AtivoInativo.Type);
            });
            //Produto
            modelBuilder.Entity<Produto>(entity =>
            {
                //entity.HasKey(e => new { e.EmpCod, e.ProCod });//Define PK
                entity.Property(e => e.ProCod).ValueGeneratedNever();//Remove Identity
                entity.Property(proSts => proSts.ProSts).HasColumnType(Type.Status_AtivoInativo.Type);
            });
        }
    }
}
