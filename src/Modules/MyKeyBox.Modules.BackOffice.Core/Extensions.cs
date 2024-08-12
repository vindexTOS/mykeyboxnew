using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using MyKeyBox.Modules.BackOffice.Core.DAL;
using MyKeyBox.Modules.BackOffice.Core.Services.DealerShipOffice;

[assembly:InternalsVisibleTo("MyKeyBox.Modules.BackOffice.Api")]
namespace MyKeyBox.Modules.BackOffice.Core;
internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection collection)
    {
        collection.AddScoped<IDealerShipOfficeService, DealerShipService>();
        collection.AddDatabase();
        return collection;
    }
}