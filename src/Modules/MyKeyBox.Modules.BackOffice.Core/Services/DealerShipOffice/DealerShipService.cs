using Microsoft.EntityFrameworkCore;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Modules.BackOffice.Core.Exceptions;
using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Infrastructure.Persistence;


namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

internal class DealerShipService(IDealershipOfficeRepository dealershipOfficeRepository,IUnitOfWork uow):IDealerShipOfficeService
{
    public async Task<List<AllDealershipTemplateDto>> GetAllTemplateAsync()
    {
         var template=await dealershipOfficeRepository.GetAllAsync();
         return template.Select(x => new AllDealershipTemplateDto(x.Id, x.DealerName)).ToList();
    }

    public async Task<DealerShipOfficeDto> GetAsync(int id)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(id);
        if (dealership is null)
            throw new DealershipNotFoundException(id);
        
         
        return new DealerShipOfficeDto();
    }

    public async Task AddAsync(DealerShipOfficeDto dealerShipOffice)
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

    public async Task UpdateAsync(DealerShipOfficeDto dealerShipOffice)
    {
        /*var dealership=await dealershipOfficeRepository.GetByIdAsync(dealerShipOffice.DealerId);
        if (dealership is null)
            throw new DealershipNotFoundException(dealerShipOffice.DealerId);*/
        
        throw new NotImplementedException();
    }

    public Task DeleteAsync(DealerShipOfficeDto dealerShipOffice)
    {
        throw new NotImplementedException();
    }
}