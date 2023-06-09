﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1.Context;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(KisiDb))]
    partial class KisiDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinFormsApp1.Models.Kisi", b =>
                {
                    b.Property<int>("KisiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KisiId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("KisiId");

                    b.ToTable("Kisis");

                    b.HasData(
                        new
                        {
                            KisiId = 1,
                            Ad = "Ahmet",
                            Soyad = "Yılmaz",
                            Telefon = "(555) 333-22-22"
                        },
                        new
                        {
                            KisiId = 2,
                            Ad = "Mehmet",
                            Soyad = "Yılmaz",
                            Telefon = "(555) 333-22-11"
                        },
                        new
                        {
                            KisiId = 3,
                            Ad = "Elif",
                            Soyad = "Güler",
                            Telefon = "(555) 444-11-22"
                        },
                        new
                        {
                            KisiId = 4,
                            Ad = "Hakan",
                            Soyad = "Doruk",
                            Telefon = "(555) 444-33-33"
                        },
                        new
                        {
                            KisiId = 5,
                            Ad = "Erdem",
                            Soyad = "Efendi",
                            Telefon = "(444) 333-33-33"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
