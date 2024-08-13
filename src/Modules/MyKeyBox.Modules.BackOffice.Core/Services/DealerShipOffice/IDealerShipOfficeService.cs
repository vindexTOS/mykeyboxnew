using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Request;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Response;

namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

public interface IDealerShipOfficeService
{
    public Task<List<AllDealershipTemplate>> GetAllTemplateAsync();
    public Task<DealerShipRegistration> GetAsync(int id);
    public Task AddAsync(DealerShipRegistration dealerShipOffice);
    public Task UpdateAsync(DealershipUpdate dealerShipOffice);
    public Task DeleteAsync(DealerShipRegistration dealerShipOffice);
}