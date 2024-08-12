using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyKeyBox.Modules.BackOffice.Core.DAL.Repositories;
using MyKeyBox.Modules.BackOffice.Core.Repositories;
using MyKeyBox.Shared.Infrastructure.Persistence;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

internal static class Extensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection collection)
    {
        collection.AddDbContext<BackOfficeDbContext>(options =>
        {
            options.UseSqlServer("Data source=.; Initial Catalog=MyKeyBox_New;Integrated Security = SSPI;Trust Server Certificate=True");
        });
        collection.AddScoped<IDealershipOfficeRepository, DealershipOfficeRepository>();
        collection.AddScoped<IUnitOfWork>(serviceProvider=> serviceProvider.GetRequiredService<BackOfficeDbContext>());
        return collection;
    }
}