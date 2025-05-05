using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace Eticaret.Data
{
    public class DatabaseContext : DbContext //Veritabanı nesneleri tutacağımız yer DATABASECONTEXT
    {
        public DbSet<AppUser> AppUsers { get; set; }
<<<<<<< HEAD
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Iletisim> Iletisimler { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        
=======
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<İletisim> İletisimler { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Slider> Sliders { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Veritabanı bağlantı ayarı.
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-R1TM7TF\SQLEXPRESS; Database=EticaretDb; Trusted_Connection = True; TrustServerCertificate=True;  ");
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.ConfigureWarnings(warnings =>
                 warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//Çalışan Configuratioanları yapılandırır.
            base.OnModelCreating(modelBuilder);
        }

    }
}
