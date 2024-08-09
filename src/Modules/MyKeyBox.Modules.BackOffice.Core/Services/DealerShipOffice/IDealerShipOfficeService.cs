using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

public interface IDealerShipOfficeService
{
    public Task CreateDealerShip(DealerShipOfficeDto dealerShipOffice);
}