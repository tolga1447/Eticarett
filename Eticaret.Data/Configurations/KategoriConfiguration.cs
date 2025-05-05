using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Eticaret.Data.Configurations
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(x => x.Kategoriİsim).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Resim).HasMaxLength(50);
            builder.HasData(
                new Kategori
                {
                    Kategoriİsim = "Elektronik",
                    Id = 1,
                    Aktif = true,
                    UstMenu = true,
                    AnaMenuId = 0,
                    SiralamaNo = 1,
                },
                new Kategori
                {
                    Kategoriİsim = "Bilgisayar",
                    Id = 2,
                    Aktif = true,
                    UstMenu = true,
                    AnaMenuId = 0,
                    SiralamaNo = 2,
                }

                );
        }
    }
}
