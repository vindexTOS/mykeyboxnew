using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("MyKeyBox.Bootstraper")]
namespace MyKeyBox.Modules.BackOffice.Api;

internal static class BackOfficeModule
{
    public static IServiceCollection AddBackOfficeModule(this IServiceCollection collection)
    {
        return collection;
    }
}