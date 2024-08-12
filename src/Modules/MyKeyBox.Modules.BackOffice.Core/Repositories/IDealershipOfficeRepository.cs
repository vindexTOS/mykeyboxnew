using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyKeyBox.Modules.BackOffice.Core.Entities;

namespace MyKeyBox.Modules.BackOffice.Core.Repositories;

internal interface IDealershipOfficeRepository
{
    public Task<DealerShipOffice?> GetByIdAsync(int id,CancellationToken token=default);
    public Task<List<DealerShipOffice>> GetAllAsync();
    public Task<bool> ExistById(int id);
    public Task<EntityEntry<DealerShipOffice>> AddAsync(DealerShipOffice entity);
    public Task<EntityEntry<DealerShipOffice>> UpdateAsync(DealerShipOffice entity);
    public Task<EntityEntry<DealerShipOffice>> Delete(DealerShipOffice type);
}