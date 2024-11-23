using EKitap.Dom.Models;
using EKitap.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EKitap.Inf.DATA
{
    public class EKitapSatısDB : IdentityDbContext<Kullanici, Rol, int>
    {
        public EKitapSatısDB()
        {

        }

        public EKitapSatısDB(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KitapYazar> KitapYazarlar { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=MERVE;initial catalog=EKitapSatısDB;integrated security=true;trust server certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { UserId = 1, RoleId = 1 }
                );
            //Foreing Key hatasını engellemek için
            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.RoleId });
            });

            builder.Entity<Kategori>()
        .HasMany(k => k.Kitaplar)
        .WithOne(k => k.Kategori)
        .HasForeignKey(k => k.KategoriID)
        .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<KitapYazar>()
       .HasOne(ky => ky.Kitap)
       .WithMany(k => k.KitapYazar)
       .HasForeignKey(ky => ky.KitapID)
       .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<YayinEvi>().HasMany(x => x.Kitaplar).WithOne(x => x.YayinEvi).HasForeignKey(x => x.YayinEviID).OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<KitapYazar>()
            //    .HasOne(ky => ky.Yazar)
            //    .WithMany(y => y.KitapYazar)
            //    .HasForeignKey(ky => ky.YazarID)
            //    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
