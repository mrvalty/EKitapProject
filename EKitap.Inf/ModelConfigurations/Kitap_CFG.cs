using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKitap.Domain.Models;

namespace EKitap.Inf.ModelConfigurations
{
    public class Kitap_CFG : BaseConfiguration<Kitap>, IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KitapAdi)
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Fiyat)
                   .HasColumnType("money")
                   .IsRequired();

            builder.Property(x => x.Aciklama)
                   .HasColumnType("varchar")
                   .HasMaxLength(300)
                   .IsRequired(false);

            builder.Property(x => x.KitapResmi)
                  .HasColumnType("varchar")
                  .HasMaxLength(100)
                  .IsRequired(false)
                  .HasDefaultValue("bosResim.jpg");
        }
    }
}