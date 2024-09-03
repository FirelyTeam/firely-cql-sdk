/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Runtime.Hosting;

internal static class ServiceProviderExtensions
{
    public static IOptions<T> GetOptions<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<IOptions<T>>();

    public static T GetOptionsValue<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetOptions<T>().Value;

    public static ILoggerFactory GetLoggerFactory(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<ILoggerFactory>();

    public static ILogger<T> GetLogger<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<ILogger<T>>();
}