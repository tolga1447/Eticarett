﻿// <auto-generated />
using System;
using Eticaret.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eticaret.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

<<<<<<< HEAD
            modelBuilder.Entity("Eticaret.Core.Entities.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcikAdres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("AdresGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAktif")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFaturaAdresi")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTeslimatAdresi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("İlce")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Adresler");
                });

=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
            modelBuilder.Entity("Eticaret.Core.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciAdi")
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<Guid?>("KullaniciGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(15)
                        .HasColumnType("varchar (15)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aktif = true,
                            Email = "admin@eticaret.io",
                            IsAdmin = true,
                            KullaniciAdi = "Admin",
<<<<<<< HEAD
                            KullaniciGuid = new Guid("01ccaf9d-54b8-4304-a8b9-c5f27801e6ae"),
                            OlusturmaTarihi = new DateTime(2025, 5, 2, 16, 6, 29, 96, DateTimeKind.Local).AddTicks(3367),
=======
                            KullaniciGuid = new Guid("aaf8f767-2106-4699-abf6-a70b6496583d"),
                            OlusturmaTarihi = new DateTime(2025, 2, 24, 19, 25, 51, 871, DateTimeKind.Local).AddTicks(7354),
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
                            Sifre = "123456*",
                            Soyisim = "Test",
                            İsim = "Test"
                        });
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Bildirim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
<<<<<<< HEAD
                        .HasColumnType("nvarchar(max)");
=======
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar (50)");

                    b.HasKey("Id");

                    b.ToTable("Bildirimler");
                });

<<<<<<< HEAD
            modelBuilder.Entity("Eticaret.Core.Entities.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<bool>("Okundu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("varchar (20)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.HasKey("Id");

                    b.ToTable("Iletisimler");
                });

=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
            modelBuilder.Entity("Eticaret.Core.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int>("AnaMenuId")
                        .HasColumnType("int");

                    b.Property<string>("Kategoriİsim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SiralamaNo")
                        .HasColumnType("int");

                    b.Property<bool>("UstMenu")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aktif = true,
                            AnaMenuId = 0,
                            Kategoriİsim = "Elektronik",
<<<<<<< HEAD
                            OlusturmaTarihi = new DateTime(2025, 5, 2, 16, 6, 29, 99, DateTimeKind.Local).AddTicks(9181),
=======
                            OlusturmaTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
                            SiralamaNo = 1,
                            UstMenu = true
                        },
                        new
                        {
                            Id = 2,
                            Aktif = true,
                            AnaMenuId = 0,
                            Kategoriİsim = "Bilgisayar",
<<<<<<< HEAD
                            OlusturmaTarihi = new DateTime(2025, 5, 2, 16, 6, 29, 99, DateTimeKind.Local).AddTicks(9949),
=======
                            OlusturmaTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
                            SiralamaNo = 2,
                            UstMenu = true
                        });
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Markaİsim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiralamaNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Baslık")
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<string>("Link")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Resim")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<bool>("AnaSayfa")
                        .HasColumnType("bit");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int?>("MarkaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SiralamaNo")
                        .HasColumnType("int");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.Property<decimal>("UrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrunKodu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Urunİsim")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("MarkaId");

                    b.ToTable("Urunler");
                });

<<<<<<< HEAD
            modelBuilder.Entity("Eticaret.Core.Entities.Adres", b =>
                {
                    b.HasOne("Eticaret.Core.Entities.AppUser", "AppUser")
                        .WithMany("Adresler")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
=======
            modelBuilder.Entity("Eticaret.Core.Entities.İletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("varchar (20)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar (50)");

                    b.HasKey("Id");

                    b.ToTable("İletisimler");
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Urun", b =>
                {
                    b.HasOne("Eticaret.Core.Entities.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId");

                    b.HasOne("Eticaret.Core.Entities.Marka", "Marka")
                        .WithMany("Urunler")
                        .HasForeignKey("MarkaId");

                    b.Navigation("Kategori");

                    b.Navigation("Marka");
                });

<<<<<<< HEAD
            modelBuilder.Entity("Eticaret.Core.Entities.AppUser", b =>
                {
                    b.Navigation("Adresler");
                });

=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
            modelBuilder.Entity("Eticaret.Core.Entities.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("Eticaret.Core.Entities.Marka", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
