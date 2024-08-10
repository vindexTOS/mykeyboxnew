using System.ComponentModel.DataAnnotations;

namespace MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;

public class DealerShipOfficeDto
{
    public int DealerId { get; set; }
    public string DealerName {get; set;} = null!;
    [Required]
    public double LocationLat {get; set;}
    [Required]
    public double LocationLong {get; set;}
    [Required] [Url]
    public string GoogleLink {get; set;} = null!;
    [Required]
    public byte WorkingHoursPerDay { get; set; }
    [Required] 
    public string ResponsiblePersonFirstName { get; set; } = null!;
    [Required] 
    public string ResponsiblePersonLastName{ get; set; } = null!;
    [Required] 
    public string ResponsiblePersonJobTitle {get; set; } = null!;
    [Required] [Phone]
    public string ResponsiblePersonPhone {get; set; } = null!;
    [Required] [EmailAddress]
    public string ResponsiblePersonEmail {get; set; } = null!;
    // Start Nullable Data
    public string? BackupPersonFirstName { get; set; }
    
    public string? BackupPersonLastName { get; set; }
    
    public string? BackupPersonJobTitle { get; set; }
    
    [Compare(nameof(ResponsiblePersonPhone),ErrorMessage = "Backup phone number and Responsible Person Phone is matched please change number")]
    public string? BackupPersonPhone { get; set; }
    
    [Compare(nameof(ResponsiblePersonEmail),ErrorMessage = "Backup email and Responsible Person Email is matched please change number")]
    public string? BackupPersonEmail { get; set; }

    public string? Notes { get; set; }
    public string? Logo { get; set; }
    public string? ContactNumber { get; set; }
    public string? MCcode { get; set; }
    public string? ZipCode { get; set; }
}