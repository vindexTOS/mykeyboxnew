using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Abstractions.Persistence;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

public class DealershipOfficeRepository:Repository<,>,IDealershipOfficeRepository
{
    public DealershipOfficeRepository() : base(dbContext)
    { }
}