using EKitap.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.ModelConfigurations
{
    public class Rol_CFG : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData(
                new Rol { Id = 1, Name = "Yonetici", NormalizedName = "YONETICI", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Rol { Id = 2, Name = "Kullanici", NormalizedName = "KULLANICI", ConcurrencyStamp = Guid.NewGuid().ToString() }
                );
        }
    }
}

