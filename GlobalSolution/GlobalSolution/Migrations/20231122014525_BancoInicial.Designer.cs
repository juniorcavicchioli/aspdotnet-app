﻿// <auto-generated />
using System;
using GlobalSolution.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GlobalSolution.Migrations
{
    [DbContext(typeof(GlobalSolutionContext))]
    [Migration("20231122014525_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GlobalSolution.Entity.ContatoEmergencia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdPaciente")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPaciente");

                    b.ToTable("ContatoEmergencia");
                });

            modelBuilder.Entity("GlobalSolution.Entity.DadosIoT", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Agitacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BatimentosPorMinuto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("IdPaciente")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdPaciente");

                    b.ToTable("DadosIoT");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Instituicao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("IdModerador")
                        .HasColumnType("bigint");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IdModerador");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Moderador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Moderador");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Monitor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("IdInstituicao")
                        .HasColumnType("bigint");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Monitor");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Paciente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Colesterol")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("ConsumoAlcool")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Diabete")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Dieta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Fumante")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("HistoricoFamiliar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<bool>("Obeso")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SexoBiologico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Triglicerol")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UsoMedicamentos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MonitorPaciente", b =>
                {
                    b.Property<long>("MonitorsId")
                        .HasColumnType("bigint");

                    b.Property<long>("PacientesId")
                        .HasColumnType("bigint");

                    b.HasKey("MonitorsId", "PacientesId");

                    b.HasIndex("PacientesId");

                    b.ToTable("MonitorPaciente");
                });

            modelBuilder.Entity("GlobalSolution.Entity.ContatoEmergencia", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Paciente", "Paciente")
                        .WithMany("ContatosEmergencia")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("GlobalSolution.Entity.DadosIoT", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Paciente", "Paciente")
                        .WithMany("DadosIoTList")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Instituicao", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Moderador", "Moderador")
                        .WithMany("Instituicoes")
                        .HasForeignKey("IdModerador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moderador");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Moderador", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Monitor", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Instituicao", "Instituicao")
                        .WithMany("Monitores")
                        .HasForeignKey("IdInstituicao");

                    b.HasOne("GlobalSolution.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Paciente", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MonitorPaciente", b =>
                {
                    b.HasOne("GlobalSolution.Entity.Monitor", null)
                        .WithMany()
                        .HasForeignKey("MonitorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GlobalSolution.Entity.Paciente", null)
                        .WithMany()
                        .HasForeignKey("PacientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GlobalSolution.Entity.Instituicao", b =>
                {
                    b.Navigation("Monitores");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Moderador", b =>
                {
                    b.Navigation("Instituicoes");
                });

            modelBuilder.Entity("GlobalSolution.Entity.Paciente", b =>
                {
                    b.Navigation("ContatosEmergencia");

                    b.Navigation("DadosIoTList");
                });
#pragma warning restore 612, 618
        }
    }
}
