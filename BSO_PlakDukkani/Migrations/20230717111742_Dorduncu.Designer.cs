﻿// <auto-generated />
using System;
using BSO_PlakDukkani.Concrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BSO_PlakDukkani.Migrations
{
    [DbContext(typeof(PlakDukkaniContext))]
    [Migration("20230717111742_Dorduncu")]
    partial class Dorduncu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BSO_PlakDukkani.Concrets.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AlbumCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("AlbumFiyati")
                        .HasColumnType("float");

                    b.Property<double>("IndirimOrani")
                        .HasColumnType("float");

                    b.Property<bool>("Satistami")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Albumler");
                });

            modelBuilder.Entity("BSO_PlakDukkani.Concrets.Modul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Moduls");
                });
#pragma warning restore 612, 618
        }
    }
}
