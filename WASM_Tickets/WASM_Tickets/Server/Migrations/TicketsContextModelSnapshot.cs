﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WASM_Tickets.Server.DAL;

#nullable disable

namespace WASM_Tickets.Server.Migrations
{
    [DbContext(typeof(TicketsContext))]
    partial class TicketsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("WASM_Tickets.Shared.Tickets", b =>
                {
                    b.Property<int>("TicketsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrioridadId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SistemaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SolicitadoPor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketsId");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
