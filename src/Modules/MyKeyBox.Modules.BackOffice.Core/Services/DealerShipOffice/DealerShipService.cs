using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Modules.BackOffice.Core.Exceptions;


namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

internal class DealerShipService:IDealerShipOfficeService
{
    public async Task CreateDealerShip(DealerShipOfficeDto dealerShipOffice)
    {
        throw new DealershipOfficeAlreadyExistException(dealerShipOffice.DealerName);
        await Task.CompletedTask;
    }
}