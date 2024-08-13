using Microsoft.EntityFrameworkCore;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
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

    public async Task<BaseResponse> GetAsync(int id)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(id);
        if (dealership is null)
            throw new DealershipNotFoundException(id);
        
         
        return  new BaseResponse
        {
            DealerName=dealership.DealerName,
            LocationLat=dealership.LocationLat,
            LocationLong= dealership.LocationLong,
            GoogleLink=dealership.GoogleLink,
            WorkingHoursPerDay=dealership.WorkingHoursPerDay,
            ResponsiblePersonFirstName= dealership.ResponsiblePersonFirstName,
            ResponsiblePersonLastName=dealership.ResponsiblePersonLastName,
            ResponsiblePersonJobTitle=dealership.ResponsiblePersonJobTitle,
            ResponsiblePersonPhone= dealership.ResponsiblePersonPhone,
            ResponsiblePersonEmail=dealership.ResponsiblePersonEmail,
            BackupPersonFirstName= dealership.BackupPersonFirstName,
            BackupPersonLastName=dealership.BackupPersonLastName,
            BackupPersonJobTitle= dealership.BackupPersonJobTitle,
            BackupPersonPhone=dealership.BackupPersonPhone,
            BackupPersonEmail=dealership.BackupPersonEmail,
            Notes= dealership.Notes,
            ContactNumber=dealership.ContactNumber,
            MCcode=dealership.MCcode,
            ZipCode= dealership.ZipCode,
        };
    }

    public async Task<bool> AddAsync(DealerShipRegistration dealership)
    {
        var entry = await dealershipOfficeRepository.AddAsync(new Entities.DealerShipOffice
        {
            DealerName=dealership.DealerName,
            LocationLat=dealership.LocationLat,
            LocationLong= dealership.LocationLong,
            GoogleLink=dealership.GoogleLink,
            WorkingHoursPerDay=dealership.WorkingHoursPerDay,
            ResponsiblePersonFirstName= dealership.ResponsiblePersonFirstName,
            ResponsiblePersonLastName=dealership.ResponsiblePersonLastName,
            ResponsiblePersonJobTitle=dealership.ResponsiblePersonJobTitle,
            ResponsiblePersonPhone= dealership.ResponsiblePersonPhone,
            ResponsiblePersonEmail=dealership.ResponsiblePersonEmail,
            RegistrationDateTime=DateTime.Now,
            BackupPersonFirstName= dealership.BackupPersonFirstName,
            BackupPersonLastName=dealership.BackupPersonLastName,
            BackupPersonJobTitle= dealership.BackupPersonJobTitle,
            BackupPersonPhone=dealership.BackupPersonPhone,
            BackupPersonEmail=dealership.BackupPersonEmail,
            Notes= dealership.Notes,
            ContactNumber=dealership.ContactNumber,
            MCcode=dealership.MCcode,
            ZipCode= dealership.ZipCode,
        });
        
        if (entry.State != EntityState.Added)
            return false;
        
        return await uow.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(DealershipUpdate dealerShipOffice)
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
        if (state.State != EntityState.Modified)
            return false;
        
        return await uow.SaveChangesAsync();
    }

    public Task<bool> DeleteAsync(DealerShipRegistration dealerShipOffice)
    {
        throw new NotImplementedException();
    }
}