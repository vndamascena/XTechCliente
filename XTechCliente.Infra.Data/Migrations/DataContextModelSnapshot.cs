﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XTechCliente.Infra.Data.Contetxs;

#nullable disable

namespace XTechCliente.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XTechCliente.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataAtualizacao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAULTIMAATUALIZACAO");

                    b.Property<DateTime?>("DataCriacao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACRIACAO");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATANASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("E-MAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("CLIENTE", (string)null);
                });

            modelBuilder.Entity("XTechCliente.Domain.Entities.HistoricoAtividade", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataHora")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("TIPO");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("HISTORICOATIVIDADE", (string)null);
                });

            modelBuilder.Entity("XTechCliente.Domain.Entities.HistoricoAtividade", b =>
                {
                    b.HasOne("XTechCliente.Domain.Entities.Cliente", null)
                        .WithMany("Historicos")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("XTechCliente.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Historicos");
                });
#pragma warning restore 612, 618
        }
    }
}
