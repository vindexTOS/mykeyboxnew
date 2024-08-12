using MyKeyBox.Modules.BackOffice.Core.Entities;
using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Infrastructure.Persistence;

namespace MyKeyBox.Modules.BackOffice.Core.DAL.Repositories;

internal class DealershipOfficeRepository:Repository<DealerShipOffice,BackOfficeDbContext>,IDealershipOfficeRepository
{
    public DealershipOfficeRepository(BackOfficeDbContext dbContext) : base(dbContext) { }
}
