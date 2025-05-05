using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    public class BildirimConfiguration : IEntityTypeConfiguration<Bildirim>
    {
        public void Configure(EntityTypeBuilder<Bildirim> builder)
        {
            builder.Property(x => x.İsim).IsRequired().HasColumnType("varchar (50)").HasMaxLength(250);
<<<<<<< HEAD
            builder.Property(x => x.Aciklama);
=======
            builder.Property(x => x.Aciklama).HasMaxLength(500);
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
            builder.Property(x => x.Resim).HasMaxLength(100);
        }
    }
}
