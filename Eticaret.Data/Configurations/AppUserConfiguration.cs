using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Eticaret.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)//String alanların yapılandırılması için configuration kullandık.
        {
            builder.Property(x => x.İsim).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Soyisim).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Telefon).HasColumnType("varchar (15)").HasMaxLength(15);
            builder.Property(x => x.Sifre).IsRequired().HasColumnType("nvarchar (50)").HasMaxLength(50);
            builder.Property(x => x.KullaniciAdi).HasColumnType("varchar (50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    KullaniciAdi = "Admin",
                    Email = "admin@eticaret.io",
                    Aktif = true,
                    IsAdmin = true,
                    İsim ="Test",
                    Sifre = "123456*",
                    Soyisim = "Test",
                  
                }

                );

        }
    }
}
