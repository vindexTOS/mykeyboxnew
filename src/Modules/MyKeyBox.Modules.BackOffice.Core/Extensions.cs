using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("MyKeyBox.Modules.BackOffice.Api")]
namespace MyKeyBox.Modules.BackOffice.Core;
public static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection collection)
    {
        collection.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(Extensions).Assembly);
        });
        return collection;
    }
}