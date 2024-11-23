using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKitap.Dom.Models;

namespace EKitap.Inf.ModelConfigurations
{
    public class Yazar_CFG : BaseConfiguration<Yazar>, IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.YazarAdi)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasData(
                new Yazar { YazarID = 201, YazarAdi = "Ahmet Hamdi Tanpınar" },
                new Yazar { YazarID = 202, YazarAdi = "Yaşar Kemal" },
                new Yazar { YazarID = 203, YazarAdi = "Orhan Pamuk" },
                new Yazar { YazarID = 204, YazarAdi = "Sabahattin Ali" },
                new Yazar { YazarID = 205, YazarAdi = "Nazım Hikmet" },
                new Yazar { YazarID = 206, YazarAdi = "Halide Edib Adıvar" },
                new Yazar { YazarID = 207, YazarAdi = "Reşat Nuri Güntekin" },
                new Yazar { YazarID = 208, YazarAdi = "Oğuz Atay" },
                new Yazar { YazarID = 209, YazarAdi = "Peyami Safa" },
                new Yazar { YazarID = 210, YazarAdi = "Elif Şafak" },
                new Yazar { YazarID = 211, YazarAdi = "J.K. Rowling" },
                new Yazar { YazarID = 212, YazarAdi = "George Orwell" },
                new Yazar { YazarID = 213, YazarAdi = "J.R.R. Tolkien" },
                new Yazar { YazarID = 214, YazarAdi = "Agatha Christie" },
                new Yazar { YazarID = 215, YazarAdi = "Fyodor Dostoevsky" },
                new Yazar { YazarID = 216, YazarAdi = "Leo Tolstoy" },
                new Yazar { YazarID = 217, YazarAdi = "Ernest Hemingway" },
                new Yazar { YazarID = 218, YazarAdi = "Jane Austen" },
                new Yazar { YazarID = 219, YazarAdi = "Mark Twain" },
                new Yazar { YazarID = 220, YazarAdi = "Franz Kafka" },
                new Yazar { YazarID = 221, YazarAdi = "Charles Dickens" },
                new Yazar { YazarID = 222, YazarAdi = "Gabriel Garcia Marquez" },
                new Yazar { YazarID = 223, YazarAdi = "Haruki Murakami" },
                new Yazar { YazarID = 224, YazarAdi = "Stephen King" },
                new Yazar { YazarID = 225, YazarAdi = "Victor Hugo" },
                new Yazar { YazarID = 226, YazarAdi = "Virginia Woolf" }
            );
        }
    }
}