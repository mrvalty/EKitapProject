using EKitap.Dom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKitap.Inf.ModelConfigurations;
public class YayinEvi_CFG : BaseConfiguration<YayinEvi>, IEntityTypeConfiguration<YayinEvi>
{
    public void Configure(EntityTypeBuilder<YayinEvi> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.YayinEviID)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired();
        builder.HasData(new YayinEvi { YayinEviID = 201, YayinEviAd = "Can Yayınları" }, new YayinEvi { YayinEviID = 202, YayinEviAd = "Yapı Kredi Yayınları" }, new YayinEvi { YayinEviID = 203, YayinEviAd = "İletişim Yayınları" }, new YayinEvi { YayinEviID = 204, YayinEviAd = "Everest Yayınları" }, new YayinEvi { YayinEviID = 205, YayinEviAd = "Doğan Kitap" }, new YayinEvi { YayinEviID = 206, YayinEviAd = "Kırmızı Kedi Yayınları" }, new YayinEvi { YayinEviID = 207, YayinEviAd = "Timaş Yayınları" }, new YayinEvi { YayinEviID = 208, YayinEviAd = "Türkiye İş Bankası Kültür Yayınları" }, new YayinEvi { YayinEviID = 209, YayinEviAd = "Pegasus Yayınları" }, new YayinEvi { YayinEviID = 210, YayinEviAd = "Epsilon Yayınları" }, new YayinEvi { YayinEviID = 211, YayinEviAd = "Penguin Random House" }, new YayinEvi { YayinEviID = 212, YayinEviAd = "HarperCollins" }, new YayinEvi { YayinEviID = 213, YayinEviAd = "Simon & Schuster" }, new YayinEvi { YayinEviID = 214, YayinEviAd = "Macmillan Publishers" }, new YayinEvi { YayinEviID = 215, YayinEviAd = "Hachette Livre" });
    }
}
