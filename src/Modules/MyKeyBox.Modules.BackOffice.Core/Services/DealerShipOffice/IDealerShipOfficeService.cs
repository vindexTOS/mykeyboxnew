using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

public interface IDealerShipOfficeService
{
    public Task<DealerShipOfficeDto> GetAsync(int id);
    public Task AddAsync(DealerShipOfficeDto dealerShipOffice);
    public Task UpdateAsync(DealerShipOfficeDto dealerShipOffice);
    public Task DeleteAsync(DealerShipOfficeDto dealerShipOffice);

}