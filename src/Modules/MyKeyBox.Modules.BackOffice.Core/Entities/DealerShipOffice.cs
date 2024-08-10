using MyKeyBox.Shared.Abstractions.Common;

namespace MyKeyBox.Modules.BackOffice.Core.Entities;

internal class DealerShipOffice:Entity
{
    public string DealerName {get; set;} = null!;

    public double LocationLat {get; set;}

    public double LocationLong {get; set;}

    public string GoogleLink {get; set;} = null!;

    public byte WorkingHoursPerDay { get; set; }

    public string ResponsiblePersonFirstName { get; set; } = null!;
    public string ResponsiblePersonLastName{ get; set; } = null!;

    public string ResponsiblePersonJobTitle {get; set; } = null!;

    public string ResponsiblePersonPhone {get; set; } = null!;

    public string ResponsiblePersonEmail {get; set; } = null!;
    public DateTime RegistrationDateTime { get; init; }=DateTime.Now;
    // Start Nullable Data
    public string? BackupPersonFirstName { get; set; }
    
    public string? BackupPersonLastName { get; set; }
    
    public string? BackupPersonJobTitle { get; set; }
    
    public string? BackupPersonPhone { get; set; }
    
    public string? BackupPersonEmail { get; set; }

    public string? Notes { get; set; }
    public string? Logo { get; set; }
    public string? ContactNumber { get; set; }
    public string? MCcode { get; set; }
    public string? ZipCode { get; set; }
}