using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Shared.Abstractions.Shared;

namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

internal class DealerShipService:IDealerShipOfficeService
{
    public async Task<Result> CreateDealerShip(DealerShipOfficeDto dealerShipOffice)
    {
        await Task.CompletedTask;
        return Result.Success();
    }
}