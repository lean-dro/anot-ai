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
    [Migration("20240608050722_NovaEstrutura")]
    partial class NovaEstrutura
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("anot_ai.Models.Anotacao", b =>
                {
                    b.Property<int>("AnotacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataPrazo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnotacaoId");

                    b.ToTable("Anotacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
