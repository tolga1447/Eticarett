using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.Property(x => x.Urunİsim).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Resim).HasMaxLength(100);
            builder.Property(x => x.UrunKodu).HasMaxLength(50);


        }
    }
}
