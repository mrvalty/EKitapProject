using EKitap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.ModelConfigurations
{
    public class Kategori_CFG : BaseConfiguration<Kategori>, IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KategoriAdi)
                   .HasColumnType("varchar")
                   .HasMaxLength(30)
                   .IsRequired();

            builder.HasData(
                new Kategori { KategoriID = 101, KategoriAdi = "Roman" },
                new Kategori { KategoriID = 102, KategoriAdi = "Hikaye" },
                new Kategori { KategoriID = 103, KategoriAdi = "Bilim Kurgu" },
                new Kategori { KategoriID = 104, KategoriAdi = "Fantastik" },
                new Kategori { KategoriID = 105, KategoriAdi = "Tarih" },
                new Kategori { KategoriID = 106, KategoriAdi = "Biyografi" },
                new Kategori { KategoriID = 107, KategoriAdi = "Otobiyografi" },
                new Kategori { KategoriID = 108, KategoriAdi = "Felsefe" },
                new Kategori { KategoriID = 109, KategoriAdi = "Psikoloji" },
                new Kategori { KategoriID = 110, KategoriAdi = "Klasikler" },
                new Kategori { KategoriID = 111, KategoriAdi = "Şiir" },
                new Kategori { KategoriID = 112, KategoriAdi = "Kişisel Gelişim" },
                new Kategori { KategoriID = 113, KategoriAdi = "Çocuk Kitapları" },
                new Kategori { KategoriID = 114, KategoriAdi = "Edebiyat" },
                new Kategori { KategoriID = 115, KategoriAdi = "Sanat" },
                new Kategori { KategoriID = 116, KategoriAdi = "Din" },
                new Kategori { KategoriID = 117, KategoriAdi = "Gezi" },
                new Kategori { KategoriID = 118, KategoriAdi = "Araştırma-İnceleme" },
                new Kategori { KategoriID = 119, KategoriAdi = "Mizah" },
                new Kategori { KategoriID = 120, KategoriAdi = "Ansiklopedi" }
            );
        }
    }
}
