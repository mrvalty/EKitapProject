using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.ModelConfigurations
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.EklenmeTarihi)
                   .HasColumnType("smalldatetime")
                   .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.GuncellemeTarihi)
                  .HasColumnType("smalldatetime")
                  .IsRequired(false);

            builder.Property(x => x.SilmeTarihi)
                  .HasColumnType("smalldatetime")
                  .IsRequired(false);

            builder.Property(x => x.KayitDurumu)
                   .HasDefaultValue(KayitDurumu.YeniKayit);
        }
    }
}
