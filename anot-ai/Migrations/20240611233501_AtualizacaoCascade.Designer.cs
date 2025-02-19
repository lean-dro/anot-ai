﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using anot_ai.Data;

#nullable disable

namespace anot_ai.Migrations
{
    [DbContext(typeof(AnotacaoContext))]
    [Migration("20240611233501_AtualizacaoCascade")]
    partial class AtualizacaoCascade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("anot_ai.Models.Anotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataPrazo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Anotacoes");
                });

            modelBuilder.Entity("anot_ai.Models.Etapa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Acao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroEtapa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlanoAcaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlanoAcaoId");

                    b.ToTable("Etapas");
                });

            modelBuilder.Entity("anot_ai.Models.Monitoramento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnotacaoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Check")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AnotacaoId")
                        .IsUnique();

                    b.ToTable("Monitoramentos");
                });

            modelBuilder.Entity("anot_ai.Models.PlanoAcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnotacaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AnotacaoId")
                        .IsUnique();

                    b.ToTable("PlanosAcao");
                });

            modelBuilder.Entity("anot_ai.Models.Smart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achievable")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AnotacaoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Measurable")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Relevant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specific")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AnotacaoId")
                        .IsUnique();

                    b.ToTable("Smarts");
                });

            modelBuilder.Entity("anot_ai.Models.Etapa", b =>
                {
                    b.HasOne("anot_ai.Models.PlanoAcao", "PlanoAcao")
                        .WithMany("Etapas")
                        .HasForeignKey("PlanoAcaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanoAcao");
                });

            modelBuilder.Entity("anot_ai.Models.Monitoramento", b =>
                {
                    b.HasOne("anot_ai.Models.Anotacao", "Anotacao")
                        .WithOne("Monitoramento")
                        .HasForeignKey("anot_ai.Models.Monitoramento", "AnotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anotacao");
                });

            modelBuilder.Entity("anot_ai.Models.PlanoAcao", b =>
                {
                    b.HasOne("anot_ai.Models.Anotacao", "Anotacao")
                        .WithOne("PlanoAcao")
                        .HasForeignKey("anot_ai.Models.PlanoAcao", "AnotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anotacao");
                });

            modelBuilder.Entity("anot_ai.Models.Smart", b =>
                {
                    b.HasOne("anot_ai.Models.Anotacao", "Anotacao")
                        .WithOne("Smart")
                        .HasForeignKey("anot_ai.Models.Smart", "AnotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anotacao");
                });

            modelBuilder.Entity("anot_ai.Models.Anotacao", b =>
                {
                    b.Navigation("Monitoramento")
                        .IsRequired();

                    b.Navigation("PlanoAcao")
                        .IsRequired();

                    b.Navigation("Smart")
                        .IsRequired();
                });

            modelBuilder.Entity("anot_ai.Models.PlanoAcao", b =>
                {
                    b.Navigation("Etapas");
                });
#pragma warning restore 612, 618
        }
    }
}
