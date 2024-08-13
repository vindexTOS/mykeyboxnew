using System.ComponentModel.DataAnnotations;

namespace MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Request;

public class DealerShipRegistration:BaseDealership
{
    public override string DealerName {get; set;} = null!;
    [Required]
    public override double LocationLat {get; set;}
    [Required]
    public override double LocationLong {get; set;}
    [Required] [Url]
    public override string GoogleLink {get; set;} = null!;
    [Required]
    public override byte WorkingHoursPerDay { get; set; }
    [Required] 
    public override string ResponsiblePersonFirstName { get; set; } = null!;
    [Required] 
    public override string ResponsiblePersonLastName{ get; set; } = null!;
    [Required] 
    public override string ResponsiblePersonJobTitle {get; set; } = null!;
    [Required] [Phone]
    public override string ResponsiblePersonPhone {get; set; } = null!;
    [Required] [EmailAddress]
    public override string ResponsiblePersonEmail {get; set; } = null!;
    // Start Nullable Data
    public override string? BackupPersonFirstName { get; set; }
    
    public override string? BackupPersonLastName { get; set; }
    
    public override string? BackupPersonJobTitle { get; set; }
    
    [Phone]
    public override string? BackupPersonPhone { get; set; }
    
    [EmailAddress]
    public override string? BackupPersonEmail { get; set; }

    public override string? Notes { get; set; }
    public override string? ContactNumber { get; set; }
    public override int? MCcode { get; set; }
    public override int? ZipCode { get; set; }
}