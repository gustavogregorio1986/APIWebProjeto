﻿// <auto-generated />
using System;
using APIWeb.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIWeb.Data.Migrations
{
    [DbContext(typeof(APIWebContexto))]
    [Migration("20220416013706_CriarTabelasBanco")]
    partial class CriarTabelasBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Aeroporto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Passageiro")
                        .HasColumnType("int");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Passageiro");

                    b.ToTable("tb_Aeroporto");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Aviao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Companhia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataChegada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPartida")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Aeroporto")
                        .HasColumnType("int");

                    b.Property<int>("NumeroVoo")
                        .HasColumnType("int");

                    b.Property<string>("Poltrona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Aeroporto");

                    b.ToTable("tb_Aviao");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Aviao")
                        .HasColumnType("int");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<int>("QtdePassageiro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Aviao");

                    b.ToTable("tb_Pagamento");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Passageiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPassageiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePassageiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_Passageiro");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Aeroporto", b =>
                {
                    b.HasOne("APIWeb.Dominio.Dominio.Passageiro", "Passageiro")
                        .WithMany()
                        .HasForeignKey("Id_Passageiro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passageiro");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Aviao", b =>
                {
                    b.HasOne("APIWeb.Dominio.Dominio.Aeroporto", "Aeroporto")
                        .WithMany()
                        .HasForeignKey("Id_Aeroporto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aeroporto");
                });

            modelBuilder.Entity("APIWeb.Dominio.Dominio.Pagamento", b =>
                {
                    b.HasOne("APIWeb.Dominio.Dominio.Aviao", "Aviao")
                        .WithMany()
                        .HasForeignKey("Id_Aviao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aviao");
                });
#pragma warning restore 612, 618
        }
    }
}
