using EKitap.Dom.Models;
using EKitap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKitap.Inf.ModelConfigurations;
public class IletisimBilgisi_CFG : BaseConfiguration<IletisimBilgisi>, IEntityTypeConfiguration<IletisimBilgisi>
{
    public void Configure(EntityTypeBuilder<IletisimBilgisi> builder)
    {
        base.Configure(builder);

    }
}
