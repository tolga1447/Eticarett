using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(x => x.Baslık).HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Aciklama).HasMaxLength(500);
            builder.Property(x => x.Resim).HasMaxLength(100);
            builder.Property(x => x.Link).HasMaxLength(50);
        }
    }
}
