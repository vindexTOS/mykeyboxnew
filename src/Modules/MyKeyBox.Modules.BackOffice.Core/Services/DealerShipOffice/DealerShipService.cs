using Microsoft.EntityFrameworkCore;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Request;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Response;
using MyKeyBox.Modules.BackOffice.Core.Exceptions;
using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Infrastructure.Persistence;


namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

internal class DealerShipService(IDealershipOfficeRepository dealershipOfficeRepository,IUnitOfWork uow):IDealerShipOfficeService
{
    public async Task<List<AllDealershipTemplate>> GetAllTemplateAsync()
    {
         var template=await dealershipOfficeRepository.GetAllAsync();
         return template.Select(x => new AllDealershipTemplate(x.Id, x.DealerName)).ToList();
    }

    public async Task<DealerShipRegistration> GetAsync(int id)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(id);
        if (dealership is null)
            throw new DealershipNotFoundException(id);
        
         
        return new DealerShipRegistration();
    }

    public async Task AddAsync(DealerShipRegistration dealerShipOffice)
    {
        var entry = await dealershipOfficeRepository.AddAsync(new Entities.DealerShipOffice
        {
            DealerName=dealerShipOffice.DealerName,
            LocationLat=dealerShipOffice.LocationLat,
            LocationLong= dealerShipOffice.LocationLong,
            GoogleLink=dealerShipOffice.GoogleLink,
            WorkingHoursPerDay=dealerShipOffice.WorkingHoursPerDay,
            ResponsiblePersonFirstName= dealerShipOffice.ResponsiblePersonFirstName,
            ResponsiblePersonLastName=dealerShipOffice.ResponsiblePersonLastName,
            ResponsiblePersonJobTitle=dealerShipOffice.ResponsiblePersonJobTitle,
            ResponsiblePersonPhone= dealerShipOffice.ResponsiblePersonPhone,
            ResponsiblePersonEmail=dealerShipOffice.ResponsiblePersonEmail,
            RegistrationDateTime=DateTime.Now,
            BackupPersonFirstName= dealerShipOffice.BackupPersonFirstName,
            BackupPersonLastName=dealerShipOffice.BackupPersonLastName,
            BackupPersonJobTitle= dealerShipOffice.BackupPersonJobTitle,
            BackupPersonPhone=dealerShipOffice.BackupPersonPhone,
            BackupPersonEmail=dealerShipOffice.BackupPersonEmail,
            Notes= dealerShipOffice.Notes,
            ContactNumber=dealerShipOffice.ContactNumber,
            MCcode=dealerShipOffice.MCcode,
            ZipCode= dealerShipOffice.ZipCode,
        });
        if (entry.State == EntityState.Added)
            await uow.SaveChangesAsync();
    }

    public async Task UpdateAsync(DealershipUpdate dealerShipOffice)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(dealerShipOffice.Id);
        if (dealership is null)
            throw new DealershipNotFoundException(dealerShipOffice.Id);
        
        {
            dealership.DealerName = dealerShipOffice.DealerName;
            dealership.LocationLat=dealerShipOffice.LocationLat;
            dealership.LocationLong= dealerShipOffice.LocationLong;
            dealership.GoogleLink=dealerShipOffice.GoogleLink;
            dealership.WorkingHoursPerDay=dealerShipOffice.WorkingHoursPerDay;
            dealership.ResponsiblePersonFirstName= dealerShipOffice.ResponsiblePersonFirstName;
            dealership.ResponsiblePersonLastName=dealerShipOffice.ResponsiblePersonLastName;
            dealership.ResponsiblePersonJobTitle=dealerShipOffice.ResponsiblePersonJobTitle;
            dealership.ResponsiblePersonPhone= dealerShipOffice.ResponsiblePersonPhone;
            dealership.ResponsiblePersonEmail=dealerShipOffice.ResponsiblePersonEmail;
            dealership.RegistrationDateTime=DateTime.Now;
            dealership.BackupPersonFirstName= dealerShipOffice.BackupPersonFirstName;
            dealership.BackupPersonLastName=dealerShipOffice.BackupPersonLastName;
            dealership.BackupPersonJobTitle= dealerShipOffice.BackupPersonJobTitle;
            dealership.BackupPersonPhone=dealerShipOffice.BackupPersonPhone;
            dealership.BackupPersonEmail=dealerShipOffice.BackupPersonEmail;
            dealership.Notes= dealerShipOffice.Notes;
            dealership.ContactNumber=dealerShipOffice.ContactNumber;
            dealership.MCcode=dealerShipOffice.MCcode;
            dealership.ZipCode= dealerShipOffice.ZipCode;
        }
        var state=await dealershipOfficeRepository.UpdateAsync(dealership);
        if (state.State == EntityState.Modified)
            await uow.SaveChangesAsync();
    }

    public Task DeleteAsync(DealerShipRegistration dealerShipOffice)
    {
        throw new NotImplementedException();
    }
}