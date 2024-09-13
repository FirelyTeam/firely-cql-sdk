/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packager.DependencyInjection;

internal static class PackagerCliServiceProviderExtensions
{
    public static PackagerCliProgram PackagerCliProgramScoped(this IServiceProvider serviceProvider1) => serviceProvider1.GetRequiredService<PackagerCliProgram>();
}