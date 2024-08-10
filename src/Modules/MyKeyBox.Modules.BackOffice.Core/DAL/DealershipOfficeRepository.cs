using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Infrastructure.Persistence;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

internal class DealershipOfficeRepository:Repository<,>,IDealershipOfficeRepository
{
    public DealershipOfficeRepository() : base(dbContext)
    { }
}
