﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AP1_Emely.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221005221151_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Aportes", b =>
                {
                    b.Property<int>("AporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Observacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Persona")
                        .HasColumnType("TEXT");

                    b.HasKey("AporteId");

                    b.ToTable("Aportes");
                });
#pragma warning restore 612, 618
        }
    }
}
