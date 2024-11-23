using EKitap.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKitap.Inf.ModelConfigurations
{
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(x => x.Ad)
                  .HasColumnType("varchar")
                  .HasMaxLength(20)
                  .IsRequired();

            builder.Property(x => x.Soyad)
                  .HasColumnType("varchar")
                  .HasMaxLength(20)
                  .IsRequired();

            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Bilge",
                Soyad = "Adam",
                UserName = "blgAdm",
                NormalizedUserName = "BLGADM",
                Email = "bilgeadam@deneme.com",
                NormalizedEmail = "BILGEADAM@DENEME.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = false
            };

            PasswordHasher<Kullanici> hasher = new PasswordHasher<Kullanici>();
            kullanici.PasswordHash = hasher.HashPassword(kullanici, "BilgeAdam123!");

            builder.HasData(kullanici);
        }
    }
}