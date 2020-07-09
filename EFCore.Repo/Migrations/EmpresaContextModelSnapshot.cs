﻿// <auto-generated />
using EFCore.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Repo.Migrations
{
    [DbContext(typeof(EmpresaContext))]
    partial class EmpresaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.Domain.Empresa", b =>
                {
                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("EmpCpfCnpj")
                        .HasColumnType("VARCHAR(18)");

                    b.Property<string>("EmpFan")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("EmpRaz")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<byte?>("EmpSts")
                        .HasColumnType("TINYINT");

                    b.HasKey("EmpCod");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("EFCore.Domain.Filial", b =>
                {
                    b.Property<int>("FilCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("FilFan")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("FilRaz")
                        .HasColumnType("VARCHAR(150)");

                    b.HasKey("FilCod");

                    b.HasIndex("EmpCod");

                    b.ToTable("Filial");
                });

            modelBuilder.Entity("EFCore.Domain.Marca", b =>
                {
                    b.Property<int>("MarCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("MarNom")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("MarCod");

                    b.HasIndex("EmpCod");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("EFCore.Domain.Pessoa", b =>
                {
                    b.Property<int>("PesCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("PesCpfCnpj")
                        .HasColumnType("VARCHAR(18)");

                    b.Property<string>("PesFan")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("PesRaz")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<byte?>("PesSts")
                        .HasColumnType("TINYINT");

                    b.HasKey("PesCod");

                    b.HasIndex("EmpCod");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("EFCore.Domain.Produto", b =>
                {
                    b.Property<int>("ProCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("ProNcm")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("ProNom")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("ProObs")
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<byte?>("ProSts")
                        .HasColumnType("TINYINT");

                    b.HasKey("ProCod");

                    b.HasIndex("EmpCod");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("EFCore.Domain.Usuario", b =>
                {
                    b.Property<int>("UsuCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<string>("UsuNom")
                        .HasColumnType("VARCHAR(75)");

                    b.Property<byte?>("UsuSts")
                        .HasColumnType("TINYINT");

                    b.Property<string>("UsuTip")
                        .HasColumnType("VARCHAR(1)");

                    b.HasKey("UsuCod");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EFCore.Domain.UsuarioEmpresas", b =>
                {
                    b.Property<int>("UsuCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<int>("EmpCod")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.HasKey("UsuCod");

                    b.HasIndex("EmpCod");

                    b.ToTable("UsuarioEmpresas");
                });

            modelBuilder.Entity("EFCore.Domain.Filial", b =>
                {
                    b.HasOne("EFCore.Domain.Empresa", "empresa")
                        .WithMany()
                        .HasForeignKey("EmpCod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Domain.Marca", b =>
                {
                    b.HasOne("EFCore.Domain.Empresa", "empresa")
                        .WithMany()
                        .HasForeignKey("EmpCod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Domain.Pessoa", b =>
                {
                    b.HasOne("EFCore.Domain.Empresa", "empresa")
                        .WithMany()
                        .HasForeignKey("EmpCod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Domain.Produto", b =>
                {
                    b.HasOne("EFCore.Domain.Empresa", "empresa")
                        .WithMany()
                        .HasForeignKey("EmpCod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Domain.UsuarioEmpresas", b =>
                {
                    b.HasOne("EFCore.Domain.Empresa", "empresa")
                        .WithMany()
                        .HasForeignKey("EmpCod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
