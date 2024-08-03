using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using MyKeyBox.Modules.BackOffice.Core;

[assembly:InternalsVisibleTo("MyKeyBox.Bootstraper")]
namespace MyKeyBox.Modules.BackOffice.Api;

internal static class BackOfficeModule
{
    public static IServiceCollection AddBackOfficeModule(this IServiceCollection collection)
    {
        collection.AddCore();
        return collection;
    }
}