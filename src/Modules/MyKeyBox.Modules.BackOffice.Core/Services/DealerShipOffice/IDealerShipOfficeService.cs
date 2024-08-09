using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Shared.Abstractions.Shared;
namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

public interface IDealerShipOfficeService
{
    public Task<Result> CreateDealerShip(DealerShipOfficeDto dealerShipOffice);
}