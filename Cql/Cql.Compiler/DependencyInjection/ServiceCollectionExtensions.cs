using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.Compiler.DependencyInjection;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection TryAddSingletonSwitch<TService, TImpl0, TImpl1>(
        this IServiceCollection services,
        Func<IServiceProvider, int> switchFn)
        where TService : class
        where TImpl0 : class, TService
        where TImpl1 : class, TService
    {
        services.TryAddSingleton<TService>(
            sp => switchFn(sp) switch
            {
                0 => ActivatorUtilities.CreateInstance<TImpl0>(sp),
                1 => ActivatorUtilities.CreateInstance<TImpl1>(sp),
                _ => throw new InvalidOperationException("Invalid switch value")
            });
        return services;
    }
}