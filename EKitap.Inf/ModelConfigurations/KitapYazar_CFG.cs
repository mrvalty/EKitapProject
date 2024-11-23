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
    public class KitapYazar_CFG : BaseConfiguration<KitapYazar>, IEntityTypeConfiguration<KitapYazar>
    {
        public void Configure(EntityTypeBuilder<KitapYazar> builder)
        {
            base.Configure(builder);

        }
    }
}