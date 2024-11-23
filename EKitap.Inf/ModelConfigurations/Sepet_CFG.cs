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
    public class Sepet_CFG : BaseConfiguration<Sepet>,
        IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Adet)
                   .HasColumnType("smallint");

        }
    }
}