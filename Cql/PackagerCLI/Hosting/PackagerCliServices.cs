/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packager.Hosting;

internal readonly record struct PackagerCliServices(IServiceProvider serviceProvider)
{
    public IServiceProvider ServiceProvider { get; } = serviceProvider;

    public PackagerCliProgram PackagerCliProgramScoped() => serviceProvider.GetRequiredService<PackagerCliProgram>();
    public OptionsConsoleDumper OptionsConsoleDumper => serviceProvider.GetRequiredService<OptionsConsoleDumper>();
}