using Microsoft.Extensions.DependencyInjection;
using MyKeyBox.Modules.BackOffice.Core.DAL.Repositories;
using MyKeyBox.Modules.BackOffice.Core.Repositories;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

internal static class Extensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection collection)
    {
        collection.AddDbContext<BackOfficeDbContext>();
        collection.AddScoped<IDealershipOfficeRepository, DealershipOfficeRepository>();
        return collection;
    }
}