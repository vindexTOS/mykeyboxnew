using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyKeyBox.Modules.BackOffice.Core.Entities;

namespace MyKeyBox.Modules.BackOffice.Core.DAL.Configurations;

public class DealershipOfficeConfiguration:IEntityTypeConfiguration<DealerShipOffice>
{
    public void Configure(EntityTypeBuilder<DealerShipOffice> builder)
    {
        builder.HasKey("Id");
    }
}