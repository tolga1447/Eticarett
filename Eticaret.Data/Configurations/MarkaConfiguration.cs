using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    public class MarkaConfiguration : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            builder.Property(x => x.Markaİsim).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Logo).HasMaxLength(50);
        }
    }
}
