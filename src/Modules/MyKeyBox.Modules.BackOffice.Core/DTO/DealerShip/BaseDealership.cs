using System.ComponentModel.DataAnnotations;

namespace MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;

public abstract class BaseDealership
{
    public virtual int Id {get; set;}
    public virtual string DealerName {get; set;} = null!;
    public virtual double LocationLat {get; set;}
    public virtual double LocationLong {get; set;}
    public virtual string GoogleLink {get; set;} = null!;
    public virtual byte WorkingHoursPerDay { get; set; }
    public virtual string ResponsiblePersonFirstName { get; set; } = null!;
    public virtual string ResponsiblePersonLastName{ get; set; } = null!;
    public virtual string ResponsiblePersonJobTitle {get; set; } = null!;
    public virtual string ResponsiblePersonPhone {get; set; } = null!;
    public virtual string ResponsiblePersonEmail {get; set; } = null!;
    // Start Nullable Data
    public virtual string? BackupPersonFirstName { get; set; }
    
    public virtual string? BackupPersonLastName { get; set; }
    
    public virtual string? BackupPersonJobTitle { get; set; }
    
    public virtual string? BackupPersonPhone { get; set; }
    
    public virtual string? BackupPersonEmail { get; set; }

    public virtual string? Notes { get; set; }
    public virtual string? ContactNumber { get; set; }
    public virtual int? MCcode { get; set; }
    public virtual int? ZipCode { get; set; }
}