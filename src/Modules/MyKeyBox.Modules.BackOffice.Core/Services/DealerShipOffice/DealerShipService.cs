using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Modules.BackOffice.Core.Exceptions;
using MyKeyBox.Modules.BackOffice.Core.Repositories;


namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

internal class DealerShipService(IDealershipOfficeRepository dealershipOfficeRepository):IDealerShipOfficeService
{
    public async Task<DealerShipOfficeDto> GetAsync(int id)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(id);
        if (dealership is null)
            throw new DealershipNotFoundException(id);
        
         
        return new DealerShipOfficeDto();
    }

    public Task AddAsync(DealerShipOfficeDto dealerShipOffice)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(DealerShipOfficeDto dealerShipOffice)
    {
        var dealership=await dealershipOfficeRepository.GetByIdAsync(dealerShipOffice.DealerId);
        if (dealership is null)
            throw new DealershipNotFoundException(dealerShipOffice.DealerId);
        
        throw new NotImplementedException();
    }

    public Task DeleteAsync(DealerShipOfficeDto dealerShipOffice)
    {
        throw new NotImplementedException();
    }
}