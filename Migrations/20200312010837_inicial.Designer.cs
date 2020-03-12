﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroLLamada.Data;

namespace RegistroLLamada.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200312010837_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("RegistroLLamada.Models.LlamadaDetalle", b =>
                {
                    b.Property<int>("LlamadaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LlamadaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Problemas")
                        .HasColumnType("TEXT");

                    b.Property<string>("Solucion")
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadaDetalleId");

                    b.HasIndex("LlamadaId");

                    b.ToTable("LlamadaDetalle");
                });

            modelBuilder.Entity("RegistroLLamada.Models.Llamadas", b =>
                {
                    b.Property<int>("LlamadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadaId");

                    b.ToTable("Llamadas");
                });

            modelBuilder.Entity("RegistroLLamada.Models.LlamadaDetalle", b =>
                {
                    b.HasOne("RegistroLLamada.Models.Llamadas", null)
                        .WithMany("Detalles")
                        .HasForeignKey("LlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
