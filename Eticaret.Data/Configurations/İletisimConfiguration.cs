using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
<<<<<<< HEAD
    public class İletisimConfiguration : IEntityTypeConfiguration<Iletisim>
    {
        public void Configure(EntityTypeBuilder<Iletisim> builder)
=======
    public class İletisimConfiguration : IEntityTypeConfiguration<İletisim>
    {
        public void Configure(EntityTypeBuilder<İletisim> builder)
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        {
            builder.Property(x => x.İsim).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Soyisim).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Telefon).HasColumnType("varchar (20)").HasMaxLength(20);
            builder.Property(x => x.Mesaj).IsRequired().HasMaxLength(400);

        }
    }
}
