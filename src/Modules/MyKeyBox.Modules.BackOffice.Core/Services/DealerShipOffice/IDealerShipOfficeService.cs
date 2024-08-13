using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Request;
using MyKeyBox.Modules.BackOffice.Core.DTO.DealerShip.Response;

namespace MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

public interface IDealerShipOfficeService
{
    public Task<List<AllDealershipTemplate>> GetAllTemplateAsync();
    public Task<BaseResponse> GetAsync(int id);
    public Task<bool> AddAsync(DealerShipRegistration dealership);
    public Task<bool> UpdateAsync(DealershipUpdate dealerShipOffice);
    public Task<bool> DeleteAsync(DealerShipRegistration dealerShipOffice);
}