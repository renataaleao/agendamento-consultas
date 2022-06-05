﻿// <auto-generated />
using AgendaConsultaAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaConsultaAPI.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20220605010404_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgendaConsultaAPI.Model.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cpf")
                        .HasColumnType("double");

                    b.Property<string>("Dia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.HasKey("Id");

                    b.ToTable("consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
