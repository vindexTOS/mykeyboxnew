using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyKeyBox.Modules.BackOffice.Core.Entities;

namespace MyKeyBox.Modules.BackOffice.Core.DAL.Configurations;

public class DealershipOfficeConfiguration:IEntityTypeConfiguration<DealerShipOffice>
{
    public void Configure(EntityTypeBuilder<DealerShipOffice> builder)
    {
        builder.HasKey("Id");
        builder
            .Property(x => x.DealerName)
            .HasMaxLength(100);
        builder
            .Property(x => x.GoogleLink)
            .HasMaxLength(500);
        builder
            .Property(x => x.ResponsiblePersonFirstName)
            .HasMaxLength(100);
        builder
            .Property(x => x.ResponsiblePersonLastName)
            .HasMaxLength(100);
        builder
            .Property(x => x.ResponsiblePersonJobTitle)
            .HasMaxLength(100);
        builder
            .Property(x => x.ResponsiblePersonPhone)
            .HasMaxLength(30);
        builder
            .Property(x => x.ResponsiblePersonEmail)
            .HasMaxLength(100);
        builder
            .Property(x => x.BackupPersonFirstName)
            .HasMaxLength(100);
        builder
            .Property(x => x.BackupPersonLastName)
            .HasMaxLength(100);
        builder
            .Property(x => x.BackupPersonJobTitle)
            .HasMaxLength(100);
        builder
            .Property(x => x.BackupPersonPhone)
            .HasMaxLength(30);
        builder
            .Property(x => x.BackupPersonEmail)
            .HasMaxLength(100);
        builder
            .Property(x => x.Notes)
            .HasMaxLength(500);
        builder
            .Property(x => x.ContactNumber)
            .HasMaxLength(500);
        builder
            .Property(x => x.MCcode)
            .HasMaxLength(100);
        builder
            .Property(x => x.ZipCode)
            .HasMaxLength(50);
    }
}