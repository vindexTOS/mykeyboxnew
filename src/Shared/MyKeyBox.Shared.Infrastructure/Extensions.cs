﻿using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("MyKeyBox.Bootstraper")]
namespace MyKeyBox.Shared.Infrastructure;
internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection collection)
    {
        collection.AddSingleton<ErrorHandlerMiddleware>();
        return collection;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder builder)
    {
        builder.UseMiddleware<ErrorHandlerMiddleware>();
        return builder;
    }
}