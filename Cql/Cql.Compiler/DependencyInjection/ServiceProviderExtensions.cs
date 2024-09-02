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

namespace Hl7.Cql.Compiler.DependencyInjection;

internal static class ServiceProviderExtensions
{
    public static IOptions<T> GetOptions<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<IOptions<T>>();

    public static ILogger<T> GetLogger<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<ILogger<T>>();
}