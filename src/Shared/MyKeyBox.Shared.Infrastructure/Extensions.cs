using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using MyKeyBox.Shared.Infrastructure.Api;

[assembly:InternalsVisibleTo("MyKeyBox.Bootstraper")]

namespace MyKeyBox.Shared.Infrastructure;
internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection collection)
    {
        collection.AddControllers().ConfigureApplicationPartManager(manager =>
        {
            manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
        });
        return collection;
    }
}