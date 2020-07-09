using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using EFCore.Type;
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
        public DbSet<Marca> Marca { get; set; }
        //public DbSet<Duplicata> Duplicata { get; set; }


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
                entity.Property(e => e.EmpCod).ValueGeneratedNever(); //Remove Identity
            });

            //User
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuCod).ValueGeneratedNever();//Remove Identity
            });

            //User - Companies
            modelBuilder.Entity<UsuarioEmpresas>(entity =>
            {
                entity.Property(e => e.UsuCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
            });

            //Filial
            modelBuilder.Entity<Filial>(entity => 
            {
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.FilCod).ValueGeneratedNever();//Remove Identity
            });

            //Pessoa
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.PesCod).ValueGeneratedNever();//Remove Identity
            });

            //Product
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
                entity.Property(e => e.ProCod).ValueGeneratedNever();//Remove Identity
            });

            //Brand (pt-br: Marca)
            modelBuilder.Entity<Marca>(entity =>
            {
                entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
                entity.Property(pk => pk.MarCod).ValueGeneratedNever(); //Remove Identity
            });

            //Duplicate (pt-br: Duplicata)


            //ERROR =>

            //modelBuilder.Entity<Duplicata>().HasNoKey(); //The entity type 'Moeda' requires a primary key to be defined. If you intended to use a keyless entity type call 'HasNoKey()'
            //modelBuilder.Entity<Duplicata>(entity =>
            //{
            //    entity.Property(e => e.EmpCod).ValueGeneratedNever();//Remove Identity
            //    entity.Property(pk => pk.CreCod).ValueGeneratedNever();//RemoveIdentity
            //});
        }
    }
}
